﻿using System.Data.SqlClient;

namespace Infrastructure.Factories
{
    
    
    public interface IInstanceFromReaderFactory<out T>
    {
        //Permet de créer une fiche à partir d'une entrée de la bd
        T CreateFromReader(SqlDataReader reader);

    }
}