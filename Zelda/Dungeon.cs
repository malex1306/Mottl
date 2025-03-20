using System.Drawing;

namespace Zelda;

public class Dungeon : Room
{
   public List<Room> Rooms { get; set; }

   public Dungeon(List<int> doors) : base(doors)
   {
      Rooms = new List<Room>();
      Rooms.Add(new Room(new List<int>{ 2 }));
      Rooms.Add(new Room(new List<int>{ 4 }));
   }

   public void StartGame()
   {
      
   }
}