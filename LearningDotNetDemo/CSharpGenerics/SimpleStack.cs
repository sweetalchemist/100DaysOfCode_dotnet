// See https://aka.ms/new-console-template for more information
public class SimpleStack
{
    private readonly double[] _items;
    private int _currentIndex = -1;
    public SimpleStack() => _items = new double[10];

    //public SimpleStack()
    //{
    //    _items = new double[10];
    //}

    //public void Push(double item)
    //{
    //    _items[++_currentIndex] = item;
    //}
    public void Push(double item)=> _items[++_currentIndex] = item;

    public int Count => _currentIndex + 1;

    public double Pop() => _items[_currentIndex--]; // Return value and then decrement index by 1 to remove it.
    
}