using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET.Data;
using DOTNET.Model;
using Microsoft.EntityFrameworkCore;

namespace DOTNET.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveChagesAssync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
        public async Task<Usuario> BuscaUsuarios(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public void AdicionaUsuario(Usuario usuarioobj)
        {
            _context.Add(usuarioobj);
        }

        public void AtualizaUsuario(Usuario usuarioobj)
        {
            _context.Update(usuarioobj);
        }

        public void DeletaUsuario(Usuario usuarioobj)
        {
            _context.Remove(usuarioobj);
        }

    }
}