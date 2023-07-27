using DOTNET.Model;

namespace DOTNET.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> BuscaUsuarios();
        Task<Usuario> BuscaUsuarios(int id);
        void AdicionaUsuario(Usuario usuarioobj);
        void AtualizaUsuario(Usuario usuarioobj);
        void DeletaUsuario(Usuario usuarioobj);
        Task<bool> SaveChagesAssync();
    }
}