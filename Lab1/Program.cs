Console.WriteLine("We are going to do some measurements for a room. Please enter all measurements in inches.");
Console.WriteLine();

Console.WriteLine("Enter the length of the room: ");
double roomLength = double.Parse(Console.ReadLine());
double roomLengthFt = (roomLength - roomLength % 12) / 12;
double roomLengthInches = Math.Round(roomLength % 12, 2);
Console.WriteLine();

Console.WriteLine("Enter the width of the room: ");
double roomWidth = double.Parse(Console.ReadLine());
double roomWidthFt = (roomWidth - roomWidth % 12) / 12;
double roomWidthIn = Math.Round(roomWidth % 12, 2);
Console.WriteLine();

Console.WriteLine("Enter the height of the room: ");
double roomHeight = double.Parse(Console.ReadLine());
Console.WriteLine();

double roomPerimeter = roomLength * 2 + roomWidth * 2;
double roomPerimeterFt = (roomPerimeter - roomPerimeter % 12) / 12;
double roomPerimeterInches = Math.Round(roomPerimeter % 12 , 2);


double roomArea = roomLength * roomWidth;
double roomAreaFt = (roomArea - roomArea % 12) / 12;
double roomAreaInches = Math.Round(roomArea % 12 , 2);


double roomVolume = roomLength * roomWidth * roomHeight;
double roomVolumeFt = (roomVolume - roomVolume % 12) / 12;
double roomVolumeInches = Math.Round(roomVolume % 12 , 2);

double roomSurfaceArea = 2*(roomWidth * roomLength + roomHeight * roomLength + roomHeight * roomWidth);
double roomSurfaceAreaFt = (roomSurfaceArea - roomSurfaceArea % 12) / 12;
double roomSurfaceAreaInches = Math.Round(roomSurfaceArea % 12 , 2);


Console.WriteLine("The room's perimeter is " + roomPerimeterFt + "' " + roomPerimeterInches + "\"");
Console.WriteLine("The room's area is " + roomWidthFt + "' " + roomWidthIn + "\" x " + roomLengthFt + "' " + roomLengthInches + "\"");
Console.WriteLine("The total area is " + roomAreaFt + " square ft " + roomAreaInches + "\"");
Console.WriteLine("The volumn of the room is " + roomVolumeFt + "' " + roomVolumeInches + "\"");
Console.WriteLine("The surface area of the room is " + roomSurfaceAreaFt + "' " + roomSurfaceAreaInches + "\"");


    if (roomArea <= 3000)
    {
        Console.WriteLine("This room is small.");
    }
    else if (roomArea <= 7800)
    {
        Console.WriteLine("This room is classified as medium.");
    }
    else if (roomArea > 7800)
    {
        Console.WriteLine("This room is classified as large.");
    }

Console.WriteLine("Thank you for using my room calculator!");