using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APISALONXPERT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorSalon : ControllerBase
    {

        private SalonXpertContext _context;

        public ControladorSalon(SalonXpertContext context)
        {
            _context = context;
        }
  
        // GET: api/<ControladorSalon>
        [HttpGet("ListarServicios/{id}")]
        public IEnumerable<Servicios> ListarServicios() => _context.Servicios.ToList();


        [HttpPost("InsertServicio/{id}")]
        public IActionResult Post([FromBody] Servicios servicio)
        {
            if (servicio == null)
            {
                return BadRequest("El objeto 'servicio' es nulo.");
            }

            // Verificamos si se proporcionaron valores para Descripcion y Precio
            if (string.IsNullOrEmpty(servicio.Descripcion) || servicio.Precio <= 0)
            {
                return BadRequest("Debe proporcionar valores válidos para Descripcion y Precio.");
            }

            _context.Servicios.Add(servicio);
            _context.SaveChanges();

            return CreatedAtRoute("GetServicio", new { id = servicio.IdServicio }, servicio);
        }


        [HttpDelete("DeleteServicio/{id}")]
        public IActionResult DeleteServicios(int idServicio)
        {
            // Buscar el servicio por su ID en la base de datos
            var servicio = _context.Servicios.Find(idServicio);

            // Si el servicio no existe, devolver una respuesta NotFound
            if (servicio == null)
            {
                return NotFound();
            }

            // Eliminar el servicio de la base de datos
            _context.Servicios.Remove(servicio);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("ListarClientes/{id}")]
        public IEnumerable<Clientes> ListarClientes() => _context.Clientes.ToList();


        [HttpPost("InsertCLientes/{id}")]
        public IActionResult Post([FromBody] Clientes clientes)
        {
            if (clientes == null)
            {
                return BadRequest("El objeto 'clientes' es nulo.");
            }

            // Verificamos si se proporcionaron valores para Descripcion y Precio
            if (string.IsNullOrEmpty(clientes.Nombre) || clientes.Movil <= 0 || clientes.IdCorporacion <= 0 || clientes.TiempoCita <= 0)
            {
                return BadRequest("Debe proporcionar valores válidos");
            }

            _context.Clientes.Add(clientes);
            _context.SaveChanges();

            return CreatedAtRoute("GetClientes", new { id = clientes.IdCliente }, clientes);
        }

        [HttpDelete("DeleteClientes/{id}")]
        public IActionResult DeleteClientes(int IdCliente)
        {
            // Buscar el servicio por su ID en la base de datos
            var clientes = _context.Clientes.Find(IdCliente);

            // Si el servicio no existe, devolver una respuesta NotFound
            if (clientes == null)
            {
                return NotFound();
            }

            // Eliminar el servicio de la base de datos
            _context.Clientes.Remove(clientes);
            _context.SaveChanges();

            return NoContent();
        }

        // GET: api/<ControladorSalon>
        [HttpGet("ListarFacturacion/{id}")]
        public IEnumerable<Facturacion> ListarFacturacion() => _context.Facturacion.ToList();


        [HttpPost("InsertFacturacion/{id}")]
        public IActionResult Post([FromBody] Facturacion facturacion)
        {
            if (facturacion == null)
            {
                return BadRequest("El objeto 'facturacion' es nulo.");
            }

            // Verificamos si se proporcionaron valores para Descripcion y Precio
            if ((facturacion.Fecha == DateTime.MinValue) || facturacion.IdCliente <= 0 || facturacion.Pago <= 0 || facturacion.IdServicio <= 0)
            {
                return BadRequest("Debe proporcionar valores válidos para Facturacion.");
            }

            _context.Facturacion.Add(facturacion);
            _context.SaveChanges();

            return CreatedAtRoute("GetFacturacion", new { id = facturacion.IdFactura }, facturacion);
        }


        [HttpDelete("DeleteFactura/{id}")]
        public IActionResult DeleteFacturacion(int idFactura)
        {
            // Buscar el servicio por su ID en la base de datos
            var facturacion = _context.Servicios.Find(idFactura);

            // Si el servicio no existe, devolver una respuesta NotFound
            if (facturacion == null)
            {
                return NotFound();
            }

            // Eliminar el servicio de la base de datos
            _context.Servicios.Remove(facturacion);
            _context.SaveChanges();

            return NoContent();
        }

        // GET: api/<ControladorSalon>
        [HttpGet("ListarCorporacion/{id}")]
        public IEnumerable<Corporacion> ListarCorporacion() => _context.Corporacion.ToList();


        [HttpPost("InsertCorporacion/{id}")]
        public IActionResult Post([FromBody] Corporacion corporacion)
        {
            if (corporacion == null)
            {
                return BadRequest("El objeto 'corporacion' es nulo.");
            }

            // Verificamos si se proporcionaron valores para Descripcion y Precio
            if (string.IsNullOrEmpty(corporacion.Denominacion) || corporacion.IdCorporacion <= 0 || string.IsNullOrEmpty(corporacion.Nombre) || corporacion.Movil <= 0)
            {
                return BadRequest("Debe proporcionar valores válidos para Corporacion.");
            }

            _context.Corporacion.Add(corporacion);
            _context.SaveChanges();

            return CreatedAtRoute("AddCorporacion", new { id = corporacion.IdCorporacion }, corporacion);
        }


        [HttpDelete("DeleteCorporacion")]
        public IActionResult DeleteCorporacion(int idCorporacion)
        {
            // Buscar el servicio por su ID en la base de datos
            var corporacion = _context.Corporacion.Find(idCorporacion);

            // Si el servicio no existe, devolver una respuesta NotFound
            if (corporacion == null)
            {
                return NotFound();
            }

            // Eliminar el servicio de la base de datos
            _context.Corporacion.Remove(corporacion);
            _context.SaveChanges();

            return NoContent();
        }


        // GET: api/<ControladorSalon>
        [HttpGet("ListarCitas/{id}")]
        public IEnumerable<Citas> ListarCitas() => _context.Citas.ToList();


        [HttpPost("InsertCitas/{id}")]
        public IActionResult Post([FromBody] Citas citas)
        {
            if (citas == null)
            {
                return BadRequest("El objeto 'citas' es nulo.");
            }

            // Verificamos si se proporcionaron valores para Descripcion y Precio
            if (string.IsNullOrEmpty(citas.NombreCliente) || citas.IdCita <= 0 || string.IsNullOrEmpty(citas.NombreServicio) ||  (citas.Fecha == DateTime.MinValue))
            {
                return BadRequest("Debe proporcionar valores válidos para Citas.");
            }

            _context.Citas.Add(citas);
            _context.SaveChanges();

            return CreatedAtRoute("AddCita", new { id = citas.IdCita }, citas);
        }


        [HttpDelete("DeleteCitas/{id}")]
        public IActionResult DeleteCitas(int idCita)
        {
            // Buscar el servicio por su ID en la base de datos
            var citas = _context.Citas.Find(idCita);

            // Si el servicio no existe, devolver una respuesta NotFound
            if (citas == null)
            {
                return NotFound();
            }

            // Eliminar el servicio de la base de datos
            _context.Citas.Remove(citas);
            _context.SaveChanges();

            return NoContent();
        }


        // Nuevos Endpoints personalizados 

        [HttpGet("ObtenerClientesPorCorporacion")]
        public IActionResult ObtenerClientesPorCorporacion(int idCorporacion)
        {
            var sql = "SELECT * FROM Clientes WHERE IdCorporacion = @IdCorporacion";
            var clientes = _context.Clientes.FromSqlRaw(sql, new SqlParameter("IdCorporacion", idCorporacion)).ToList();

            return Ok(clientes);
        }

    }
}
