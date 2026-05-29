using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;
namespace SistemaEscolar.Data
{
    public class DB
    {

        private string connectionString = "Server=localhost;Database=sistema_escolar;Uid=root;Pwd=333evepamela;";

        public List<T> ConsultarStoreProcedure<T>(string nombreProcedimiento, Dictionary<string, object> parametros = null) where T : new()
        {
            List<T> listaResultados = new List<T>();

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(nombreProcedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                

                    // Agregar parámetros si existen
                    if (parametros != null)
                    {
                        foreach (var par in parametros)
                        {
                            comando.Parameters.AddWithValue(par.Key, par.Value ?? DBNull.Value);
                        }
                    }

                    try
                    {
                        conexion.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                T objeto = MapReaderToObject<T>(reader);
                                listaResultados.Add(objeto);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener lista: " + ex.Message);
                    }
                }
            }
            return listaResultados;
        }

        // Método auxiliar que mapea automáticamente las columnas a las propiedades de la clase
        private T MapReaderToObject<T>(MySqlDataReader reader) where T : new()
        {
            T obj = new T();
            PropertyInfo[] propiedades = typeof(T).GetProperties();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                string nombreColumna = reader.GetName(i);
                object valorColumna = reader.GetValue(i);

                foreach (var prop in propiedades)
                {
                    // Verifica que el nombre coincida y que el valor no sea DBNull
                    if (prop.Name.Equals(nombreColumna, StringComparison.InvariantCultureIgnoreCase) && valorColumna != DBNull.Value)
                    {
                        prop.SetValue(obj, valorColumna);
                        break;
                    }
                }
            }
            return obj;
        }
        public void EjecutarSPNoQuery(string nombreProcedimiento, Dictionary<string, object> parametros)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(nombreProcedimiento, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros dinámicamente
                        if (parametros != null)
                        {
                            foreach (var par in parametros)
                            {
                                comando.Parameters.AddWithValue(par.Key, par.Value);
                            }
                        }

                        comando.ExecuteNonQuery();
                        Console.WriteLine("Procedimiento ejecutado con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    throw ;
                }
            }
        }
    }
}
