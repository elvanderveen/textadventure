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
        public int health;
        public Player() {
            
      
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
