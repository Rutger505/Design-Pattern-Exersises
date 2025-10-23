using CommandPattern.Classes;

namespace CommandPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var remoteControl = new RemoteControl();

        /* Define and instantiate the following Vendor classes
         * Kitchen Light : Light
         * Livingroom Light : Light
         * Livingroom ceiling fan : CeilingFan
         * Garage door: Garagedoor
         * Stereo : Stereo
         */
        var kitchenLight = new Light("Kitchen");
        var livingRoomLight = new Light("Living Room");
        // Define and instantiate an Off and On command for each Vendor class

        /* Set the On and Off commands to the appropriate slot:
         *
         * 1: Living Room light
         * 2: Kitchen light
         * 3: Livingroom ceiling fan
         * 4: Garage door
         * 5: Stereo
         */

        Console.WriteLine(remoteControl);

        // Test the pressing of Buttons here. Don't forget to test the Undo button
    }
}