﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Fantasy
{
    class Human
    {
        public int _baseHealth = 20;
        public int _baseArmour = 5;
        public int _baseMana = 10;
        private int _playerLevel;

        public Human(int _playerLevel)
        {
            // LOAD PLAYERS LEVEL INTO THE INSTANCE
            this._playerLevel = _playerLevel;
        }

        private void setHelm() 
        {
            throw new NotImplementedException();
        }

        private void setChest()
        {
            throw new NotImplementedException();
        }

        private void setLegs()
        {
            throw new NotImplementedException();
        }

        private void setBoots()
        {
            throw new NotImplementedException();
        }

        private void setPrimary()
        {
            throw new NotImplementedException();
        }

        private void setSecondary()
        {
            throw new NotImplementedException();
        }

        private void setPotion()
        {
            throw new NotImplementedException();
        }


    }
}
