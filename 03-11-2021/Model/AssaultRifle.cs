using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _03_11_2021.Model
{
    class AssaultRifle : Gun
    {
        public int AmountOfBullets { get; set; }
        public int MagazineCapacity { get; set; }
        public int CurrentMagazineCount { get; set; }

        public AssaultRifle(string model,  double power, int amountOfBullets, int magazineCapacity, int currentMagazineCount) : base(model, power)
        {
            AmountOfBullets = amountOfBullets;
            MagazineCapacity = magazineCapacity;
            CurrentMagazineCount = currentMagazineCount;
        }
        #region Reload1

        public string Reload()
        {
            int Empty = MagazineCapacity - CurrentMagazineCount;
            if ((AmountOfBullets - Empty) > 0)
            {
                AmountOfBullets -= Empty;
                CurrentMagazineCount += Empty;
                return $"{Empty} gulle elave olundu";

            }
            else
            {
                CurrentMagazineCount += AmountOfBullets;
                AmountOfBullets = 0;
                return "yerde qalan gulle  magazine elave olundu ";
            }

        }
        #endregion
        #region Reload2
        public string Reload(int count)
        {
            if (count+CurrentMagazineCount>MagazineCapacity)
            {
                return $"Maghazinde {MagazineCapacity - CurrentMagazineCount} " +
                    $"yer var siz {count} gulle doldura bilmezsiz! " +
                    $" magazinni fulladiq ";
                Reload();

            }
            else if (AmountOfBullets<count)
            {
                return $"sizin yeteri qeder gulleniz yoxdu \n" +
                    $"hal hazirda qalan gulleniz:{AmountOfBullets} bu " +
                    $"qederdi ve bu gulleni magazine doldurduq";
                Reload();
            }
            else
            {
                AmountOfBullets -= count;
                CurrentMagazineCount += count;
                return $"{count} gulle dolduruldu";

            }

            }
        #endregion
        #region Shoot1
        public string Shoot()
        {
            for (int i = CurrentMagazineCount - 1; i >= 0; i--)
            {
                Thread.Sleep(2000);
                return "   ->   ";
            }
            return "Gulle bitdi Reloada ehtiyac var";
        }
        #endregion
        #region Shoot2
        public string Shoot(int Count)
        {
            CurrentMagazineCount -= 1;
            return "   ->   ";
        }
        #endregion

    }
}
