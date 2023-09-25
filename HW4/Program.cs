using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Passenger
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Seat { get; set; }

    public Passenger(int id, string name, string seat)
    {
        Id = id;
        Name = name;
        Seat = seat;

    }

    public void get_info() {
        Console.WriteLine($" ID: {Id} Name: {Name} Seat: {Seat}");
    }
}


public partial class Airplane
{
    private int _id;
    private string _manufacturer;
    private string _model;
    private int _avgSpeed ;
    private int _capacity;
    private double _fuel;
    private string _flight_number;
    private string _pilot;
    static readonly DateTime confirmed_date;
    static readonly string _airline;
    private Passenger[] passengers=new Passenger[0];



    static Airplane()
    {
        confirmed_date= DateTime.Now;
        _airline = "Air Neverwhere";
    }
    public Airplane(int id,string manufacturer, string model, int avgSpeed, int capacity, double fuel,string flight_number, string pilot)
    {
        _id = id;
        _model = model;
        _manufacturer = manufacturer;
        _avgSpeed = avgSpeed;
        _capacity = capacity;
        _fuel = fuel;
        _flight_number = flight_number;
        _pilot = pilot;
 
    }

    public Airplane()
    {
        _id = 0;
        _model = "Boeing-737-800";
        _manufacturer = "Boeing";
        _avgSpeed = 1890;
        _capacity = 189;
        _fuel = 100;
        _flight_number = null;
        _pilot = null;

    }
    public void print_info()  
    {
        Console.WriteLine($"\n Model : {_model}\n Manufacturer: {_manufacturer}\n Average Speed: {_avgSpeed} \n Capacity: {_capacity} \n Fuel: {_fuel} \n Flight Number: {_flight_number}\n Pilot: {_pilot}\n Airline: {_airline} \n Date of Confirmation: {confirmed_date} \n");
    }

    public void update_fuel(double wasted_fuel)  
    {
        if ( _fuel > 0 ) {
        _fuel -= wasted_fuel;
        }
    }

    public void refill(double refill) 
    {
        _fuel += refill;
    }
    public void update_pilot(string new_pilot)  
    {
        _pilot = new_pilot;
    }

    public void update_flight(string new_flight_number) 
    {
        _flight_number = new_flight_number;
    }



    public double get_fuel(double wasted_fuel)
    {
        return _fuel;
    }

    public void set_passengers(ref Passenger[] new_passengers)
    {
        passengers = new_passengers;
    }



}
class HW2
{
    static void Main()
    {
        Airplane test = new Airplane(11,"Boeing", "Boeing-737-800", 1900, 189, 100,"ABC123","Shawn Spencer");
        Airplane test2 = new Airplane();

        Airplane[] arr_of_airplanes = new Airplane[5];

        Passenger[] arr_of_passengers = new Passenger[5];

        for (int i=0;i<5; i++)
        {
            arr_of_airplanes[i]= new Airplane();
        }

        for (int i = 0; i < 5; i++)
        {
            arr_of_passengers[i] = new Passenger(i,"Nathan Fielder",$"{i+32}A");
        }

        arr_of_airplanes[0].print_info();
        arr_of_airplanes[0].set_passengers(ref arr_of_passengers);
        arr_of_airplanes[0].print_passengers();

    }
}   