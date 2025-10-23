using CommandPattern.Classes;
using CommandPattern.Classes.Commands;

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
        var livingRoomCeilingFan = new CeilingFan("Living Room");
        var garageLight = new Light("Garage");
        var garageDoor = new GarageDoor(garageLight);
        var stereo = new Stereo();

        // Define and instantiate an Off and On command for each Vendor class
        var livingRoomLightOn = new LightOnCommand(livingRoomLight);
        var livingRoomLightOff = new LightOffCommand(livingRoomLight);
        var kitchenLightOn = new LightOnCommand(kitchenLight);
        var kitchenLightOff = new LightOffCommand(kitchenLight);
        var ceilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
        var ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);
        var garageDoorUp = new GarageDoorUpCommand(garageDoor);
        var garageDoorDown = new GarageDoorDownCommand(garageDoor);
        var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
        var stereoOff = new StereoOffCommand(stereo);

        /* Set the On and Off commands to the appropriate slot:
         *
         * 1: Living Room light
         * 2: Kitchen light
         * 3: Livingroom ceiling fan
         * 4: Garage door
         * 5: Stereo
         */
        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
        remoteControl.SetCommand(3, garageDoorUp, garageDoorDown);
        remoteControl.SetCommand(4, stereoOnWithCd, stereoOff);

        Console.WriteLine(remoteControl);

        // Test the pressing of Buttons here. Don't forget to test the Undo button
        Console.WriteLine("\n===== TESTING COMMANDS =====\n");

        // Test Living Room Light
        Console.WriteLine("--- Test 1: Living Room Light ---");
        remoteControl.OnButtonWasPushed(0);
        remoteControl.OffButtonWasPushed(0);
        Console.WriteLine("Undo last command:");
        remoteControl.UndoButtonWasPushed();
        Console.WriteLine("Undo again:");
        remoteControl.UndoButtonWasPushed();

        Console.WriteLine("\n--- Test 2: Kitchen Light ---");
        remoteControl.OnButtonWasPushed(1);
        remoteControl.OffButtonWasPushed(1);
        Console.WriteLine("Undo:");
        remoteControl.UndoButtonWasPushed();

        Console.WriteLine("\n--- Test 3: Ceiling Fan ---");
        remoteControl.OnButtonWasPushed(2);
        remoteControl.OffButtonWasPushed(2);
        Console.WriteLine("Undo (should restore to High):");
        remoteControl.UndoButtonWasPushed();

        Console.WriteLine("\n--- Test 4: Garage Door ---");
        remoteControl.OnButtonWasPushed(3);
        remoteControl.OffButtonWasPushed(3);
        Console.WriteLine("Undo:");
        remoteControl.UndoButtonWasPushed();

        Console.WriteLine("\n--- Test 5: Stereo ---");
        remoteControl.OnButtonWasPushed(4);
        remoteControl.OffButtonWasPushed(4);
        Console.WriteLine("Undo:");
        remoteControl.UndoButtonWasPushed();

        Console.WriteLine("\n--- Test 6: Multiple Commands and Undo History ---");
        remoteControl.OnButtonWasPushed(0); // Living room light on
        remoteControl.OnButtonWasPushed(1); // Kitchen light on
        remoteControl.OnButtonWasPushed(4); // Stereo on
        Console.WriteLine("Undo last 3 commands:");
        remoteControl.UndoButtonWasPushed(); // Undo stereo
        remoteControl.UndoButtonWasPushed(); // Undo kitchen
        remoteControl.UndoButtonWasPushed(); // Undo living room

        Console.WriteLine("\n--- Test 7: Ceiling Fan Speed Changes ---");
        var ceilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);
        var ceilingFanLow = new CeilingFanLowCommand(livingRoomCeilingFan);
        remoteControl.SetCommand(5, ceilingFanMedium, ceilingFanOff);
        remoteControl.SetCommand(6, ceilingFanLow, ceilingFanOff);

        remoteControl.OnButtonWasPushed(2); // High
        remoteControl.OnButtonWasPushed(5); // Medium
        remoteControl.OnButtonWasPushed(6); // Low
        Console.WriteLine("Undo to Medium:");
        remoteControl.UndoButtonWasPushed();
        Console.WriteLine("Undo to High:");
        remoteControl.UndoButtonWasPushed();
        Console.WriteLine("Undo to Off:");
        remoteControl.UndoButtonWasPushed();

        Console.WriteLine("\n===== ALL TESTS COMPLETED =====");
    }
}