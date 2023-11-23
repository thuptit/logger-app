using RealPattern.Composite;

var menuBreakFast = new Menu("Breakfast","For the Breakfast");
menuBreakFast.Add(new MenuItem("Cake","handmade", true, 5));
menuBreakFast.Add(new MenuItem("test","tesst",false,10));


var menu = new Menu("All", "McDonalds");
menu.Add(menuBreakFast);
menu.Print();