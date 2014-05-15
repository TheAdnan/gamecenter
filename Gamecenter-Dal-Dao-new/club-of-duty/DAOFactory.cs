using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using DalDao;

namespace DAL
{
    partial class DAL
    {
        public class DAOFactory             
        {
            private static DAOFactory instanca = null;
            public static DAOFactory Instanca
            {
                get { return (instanca == null) ? instanca = new DAOFactory() : instanca; }
            }

            private DAOFactory() { }

            public IgricaDAO getIgricaDAO()
            {
                return new IgricaDAO();
            }
			public KlijentDAO getKlijentDAO()
            {
                return new KlijentDAO();
            }
			public UposlenikDAO getKlijentDAO()
            {
                return new KlijentDAO();
            }

        }
    }
}
