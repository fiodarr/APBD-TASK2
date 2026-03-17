

using APBD_TASK2.Database;
using APBD_TASK2.Models;

var db = Singleton.Instance;

var laptop = new Laptop("laplaplap", 2, 15);

db.Equipment.Add(laptop);