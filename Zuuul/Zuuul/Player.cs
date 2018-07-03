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
        private int health;
        private Boolean alive;


        public Player() {

            //Damage(amount);
            //Heal(amount);
            this.currentRoom = null;
            this.alive = true;
            this.health = 100;
        }

        public Boolean isAlive() {
            return alive;
        }

        public void Damage(int amount) {
            health = health - amount;
            if (health <= 0)
            {
                alive = false;
            }
        }
 


        public void Heal(int amount) {
            health = health + amount;
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
