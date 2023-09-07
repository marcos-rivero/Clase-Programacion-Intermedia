using Serilog;

namespace PrincipiosSolid
{
    public class Articulo
    {
        private readonly ILogging _log;
        private readonly Almacenamiento _almacenamiento;
        private readonly Cache _cache;
        public Articulo(ILogging logging, Almacenamiento almacenamiento, Cache cache)
        {
            _log = logging;
            _almacenamiento = almacenamiento;
            _cache = cache;
        }
        public string path { get; set; }
        public void GuardarArticulo(string contenido, string titulo)
        {
            _log.Info($"vamos a insertar el articulo {titulo}");
            _almacenamiento.EscribirArchivo(titulo, contenido);
            _log.Info($"articulo {titulo} insertado");
            _cache.Add(titulo, contenido);
        }

        public string ConsultarArticulo(string titulo)
        {
            string contenido = _cache.Get(titulo);
            try
            {
                _log.Info($"Consultar artículo {titulo}");

                
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    _log.Info($"Artículo encontrado en la cache {titulo}");
                    return contenido;
                }
                else
                {
                    throw new MiExceptionPersonalizada("El contenido es vacio");
                }

                _log.Info($"buscar articulo en el sistema de archivos {titulo}");
                contenido = _almacenamiento.LeerArchivo(titulo);
            }
            catch (FormatException e)
            {
                _log.Fatal("Error", e);
            }
            catch (DivideByZeroException e)
            {
                _log.Fatal("Error", e);
            }
            catch (MiExceptionPersonalizada e){
                
            }

            return contenido;
        }
    }
}
