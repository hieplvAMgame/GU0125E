using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Attack(Character target) 
        {
<<<<<<< HEAD
            int hp = 10;
            hp -= value;
=======
            target.TakeDamage(10);
        }
        public class Character
        {
            int HP;
            public void TakeDamage(int val) => HP -= val;
>>>>>>> dev
        }
    }

}
