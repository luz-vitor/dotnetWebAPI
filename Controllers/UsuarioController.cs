using DOTNET.Model;
using DOTNET.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _repository.BuscaUsuarios();
            return usuarios.Any() ? Ok(usuarios) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _repository.BuscaUsuarios(id);
            return usuario != null ? Ok(usuario) : NotFound("Usuário não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            _repository.AdicionaUsuario(usuario);
            return await _repository.SaveChagesAssync() ? Ok("Usuário adicionado com sucesso") : BadRequest("Erro ao salvar o usuário");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Usuario usuario)
        {
            var usuarioBanco = await _repository.BuscaUsuarios(id);
            if (usuarioBanco == null) return NotFound("Usuário não encontrado");

            usuarioBanco.Nome = usuario.Nome ?? usuarioBanco.Nome;
            usuarioBanco.DataNascimento = usuario.DataNascimento != new DateTime()
            ? usuario.DataNascimento : usuarioBanco.DataNascimento;

            _repository.AtualizaUsuario(usuarioBanco);

            return await _repository.SaveChagesAssync() ? Ok("Usuário atualizado com sucesso") : BadRequest("Erro ao atualizar o usuário");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var usuarioBanco = await _repository.BuscaUsuarios(id);
            if (usuarioBanco == null) return NotFound("Usuário não encontrado");

            _repository.DeletaUsuario(usuarioBanco);

            return await _repository.SaveChagesAssync() ? Ok("Usuário deletado com sucesso") : BadRequest("Erro ao deletar o usuário");

        }

    }
}