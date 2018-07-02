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

            //Damage(amount);
            //Heal(amount);

              if (currentRoom = new Room ) {
                 if new Room = true public int playerHealth = -2;

              if (playerHealth <= 0 ) {
                  return wantToQuit; 

        }

            {
                if (health <= 0) {
                    isAlive = false;
                }
            }


        }
        void Damage(int amount) {
            amount = 10;
        }


        void Heal(int amount) {
            amount = 15;
        }
     

        public Room setCurrentRoom(Room room) {
            this.currentRoom = room;
            return room;
         }

        public Room getCurrentRoom() {
            return this.currentRoom;
        }

    }
}
