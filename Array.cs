using System;
using System.Runtime.InteropServices.Java;

int[] array = {1,2,3,4,5,6,7,8,9,10};
int[] array2 = new int[5];

// foreach(int num in array2)
// {
//     Console.WriteLine(num);
// }

// Array.Reverse(array);
// Array.Reverse(array,0,3);
// foreach(int num in array)
// {
//     Console.WriteLine(num);
// }

/*
//multi array
int[,] multiarray = new int[2,3]; //a 2d array with 2 rows and 3 columns
multiarray[0,0] = 5; //first row and first columns value
multiarray[0,1] = 6;
multiarray[1,2] = 7;

foreach(int multi in multiarray) //printing multiarray
{
    Console.Write(multi);
}
*/

/*

int[,] matrix = new int[3, 4]
{
    {1,3,4,6}, //all the values inthe first row
    {4,6,2,7}, //all the values in the second row
    {5,7,8,9}  //all the values in the third row
};

for(int row = 0; row < matrix.GetLength(0); row++) //outer loop for the rows
{
    for(int col = 0; col < matrix.GetLength(1); col++) //outer loop for the columns
    {
        Console.Write(matrix[row,col]+" ");
    }
    Console.WriteLine();

}

*/

//3d array

Console.WriteLine("🏢 BUILDING LIGHT STATUS");
Console.WriteLine("═══════════════════════════════════════\n");

// 0 = Light OFF, 1 = Light ON
int[,,] building = new int[2, 3, 2]  // 2 floors, 3 rooms, 2 lights
{
    {   // Floor 0
        { 1, 0 },   // Room 0: Light0 ON, Light1 OFF
        { 0, 0 },   // Room 1: Both OFF
        { 1, 1 }    // Room 2: Both ON
    },
    {   // Floor 1
        { 0, 1 },   // Room 0: Light0 OFF, Light1 ON
        { 1, 1 },   // Room 1: Both ON
        { 0, 0 }    // Room 2: Both OFF
    }
};

// 3 টা nested loop!
for (int floor = 0; floor < building.GetLength(0); floor++)
{
    Console.WriteLine($"🏢 Floor {floor}:");
    Console.WriteLine("   ─────────────────────────────────");

    for (int room = 0; room < building.GetLength(1); room++)
    {
        Console.Write($"   🚪 Room {room}: ");

        for (int light = 0; light < building.GetLength(2); light++)
        {
            if (building[floor, room, light] == 1)
            {
                Console.Write("💡 ");  // ON
            }
            else
            {
                Console.Write("⬛ ");  // OFF
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}