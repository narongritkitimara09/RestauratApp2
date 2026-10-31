using System.Collections.Generic;

public class Restaurant
{
    // รหัสร้าน
    public int Id { get; set; }

    // ชื่อร้าน
    public string Name { get; set; }

    // ประเภทอาหาร/ร้าน
    public string Type { get; set; }

    // คะแนนของร้าน
    public double Rating { get; set; }

    // Constructor สำหรับกำหนดค่าเริ่มต้น
    public Restaurant(int id, string name, string type, double rating)
    {
        Id = id;
        Name = name;
        Type = type;
        Rating = rating;
    }
}




internal class Program
{
    List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
        new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
        new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
        new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
        new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8)

    };
    foreach (var item in restaunrants)
    {
        console



