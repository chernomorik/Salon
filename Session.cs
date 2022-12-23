using BSalon.Models;
using BSalon.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSalon
{
    public class Session
     {
        private Session()
        {
            context = new BeautySalonContext();
        }

        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private BeautySalonContext context;
        public BeautySalonContext Context => context;
    }
}
