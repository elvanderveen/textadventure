using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuulCS
{
    class Player
    {
        private Room currentRoom;
        public int health = 100;
        private Boolean isAlive;
        public Player() {

            

            {
                if (health <= 0) {
                    isAlive = false;
                }
            }

            //Damage(amount);
            //Heal(amount);
            
      
        }

        public Room setCurrentRoom(Room room)
        {
            this.currentRoom = room;
            return room;
        }
        public Room getCurrentRoom()
        {
            return this.currentRoom;
        }

    }
}
