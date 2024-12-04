using SAKA20_Common.Entities;


namespace SAKA20_Common.Repositories
{
    public interface IUtilisateurRepository<TUtilisateur,TId,Temail> where TUtilisateur : IUtilisateur
    {
        public IEnumerable<TUtilisateur> Get();
        public TUtilisateur Get(TId id);
        public TUtilisateur Get(Temail email);
        public bool Create(TUtilisateur utilisateur);
        public void Update(TId id, TUtilisateur utilisateur);
        public void Delete(TId id);

    }
}
