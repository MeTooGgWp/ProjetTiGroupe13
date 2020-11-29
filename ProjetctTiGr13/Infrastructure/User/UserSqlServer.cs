namespace ProjetctTiGr13.Infrastructure.User
{
    public static class UserSqlServer
    {
        public static readonly string TableName = "compte";
        public static readonly string ColPseudo = "pseudo";
        public static readonly string ColIdentifiant = "identifiant";
        public static readonly string ColMdp = "mdp";

        
        //REQUETE CREATE
        public static readonly string ReqCreate = $@"
        INSERT INTO {TableName}({ColPseudo},{ColIdentifiant},{ColMdp})
        VALUES(@{ColPseudo},@{ColIdentifiant},@{ColMdp})
        ";
        
        //REQUETE QUERY ALL (même si normalement jamais utilisée : 

        public static readonly string ReqQuery = $"SELECT * FROM {TableName}";    
        
        //REQUETE d'UN USER BY PSEUDO:

        public static readonly string ReqGetByPseudo = ReqQuery + $" WHERE {ColPseudo} = @{ColPseudo}";
        
        //REQUETE UPDATE : 

        public static readonly string ReqUpdate = $@"
        UPDATE {TableName} SET
        {ColPseudo} = @{ColPseudo},
        {ColIdentifiant} = @{ColIdentifiant},
        {ColMdp} = @{ColMdp}
        ";





    }
}