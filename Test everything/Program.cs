class Program
{
    static void Main()
    {
        List<int> danhSach = new List<int> { 1, 2, 3, 4, 5 };
        int tong = danhSach.Sum();
        Console.WriteLine("Tổng của danh sách là: " + tong);
    }
}