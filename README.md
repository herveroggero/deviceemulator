# Enzo Device Emulator
This project is designed to help you build an emulated environment of devices that can send semi-random data into an Azure IoT Hub for processing. The tool communicates with Enzo Online to faciliate the communication with the IoT Hub, and allows you to view/create/delete devices, define one or more emulators (each emulator can emulate one or more devices), and view the outcome of the emulation. 

## Project Overview
The project is structured in three main sections:  UI Events, Azure IoT Event Hub calls, and HTTP/REST processing.  UI Events are just that: reacting to click events, and calling the appropriate method in the EnzoIoTHubOperations class. The calls are made using REST calls; REST processing is performed by the EnzoHttpAzureIoTHub class, which is a simple HTTP wrapper. 

The Enzo service is the layer that performs more complex processing against the IoT Hub; for example, Enzo will automatically cache the  List of devices found in the Hub for performance; and Enzo will also process the randomization nature of the payloads using functions that the client sends as part of the payload (more on this soon). 

Last but not least, since you can run multiple emulators in parallel, the tool allows you to save all your emulators as a workspace. You can quickly load previously saved workspaces. 

## Semi-Random Payloads
One of the key features of this utility is to enter a payload that is transformed by Enzo Online automatically. Since each emulator can virtualize multiple devices (hundreds), you can easily specify a payload that will vary for each device using specific functions. For example, the #deviceid() function stores the current device id; the #rdnint(a,b) returns an integer between a (included) and b (excluded), the #utcnow() returns the current timestamp in UTC, and the #rndguid() returns a random Guid. Additional functions are available, and can be found in a help file displayed from a link on the emulator window. 

Here is an example of a semi-random payload:
{ "deviceid": "#deviceid()", "clienttime": "#utcnow()", "devicetype": "#pick(lamp,fridge,door)", "value": #rndint(0,100), "uniqueid": "#rndguid()" }

Which can yields the following results when proceesed through Enzo Online by the SendTestData method:
{ "deviceid": "test13", "clienttime": "11/20/2018 7:56:16 PM", "devicetype": "door", "value": 75, "uniqueid": "3c26b346-2ec6-448a-93b2-d6b4ece8e12c" }
{ "deviceid": "test11", "clienttime": "11/20/2018 7:56:16 PM", "devicetype": "fridge", "value": 0, "uniqueid": "d01a796a-7ea9-4057-b682-209afb4d7b61" }
{ "deviceid": "test111", "clienttime": "11/20/2018 7:56:16 PM", "devicetype": "door", "value": 0, "uniqueid": "bf64079a-b48b-4339-abaf-008508356d27" }

## Enzo Online
The easiest way to use Enzo Device Emulator is to signup on the Enzo Online portal (https://portal.enzounified.com); there is a freemium level allowing you to configure a single IoT Hub. Once you have done that, you will be assigned an Authentication Token, and an Enzo Online URL that you will use to connect with Enzo SharePoint Explorer. 

You will need to create a configuration setting for your IoT Hub within the portal, so that Enzo can call the IoT Hub on your behalf. Click on the Azure IoT Hub tab on the left of the portal to access your configuration settings. 

One of the benefits of using Enzo Online is to view the recent calls made through Enzo; for example the Access Log tab on the Enzo portal (https://portal.enzounified.com/EnzoAccounting) can be used to see which methods were called, how long each call took, how many bytes were returned, and how many items were returned to the client. 
