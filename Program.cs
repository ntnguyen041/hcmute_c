using PhanSoApp;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<PhanSo> pS = new List<PhanSo>
{
    new PhanSo(1, 2),
    new PhanSo(1, -3),
   // new PhanSo(1, 0)
};
foreach (PhanSo p in pS)
{
    try {  
        Console.WriteLine(p.ToString());
    } catch(ArgumentException ex) { 
        Console.WriteLine(ex.Message);
    }

}

//// bai 2
PhanSo ps1 = new PhanSo(1, 2);
PhanSo ps2 = new PhanSo(1, 3);
Console.WriteLine($"ps1 = {ps1}");
Console.WriteLine($"ps2 = {ps2}");
Console.WriteLine($"ps1 + ps2 = {ps1 + ps2}");
Console.WriteLine($"ps1 - ps2 = {ps1 - ps2}");
Console.WriteLine($"ps1 * ps2 = {ps1 * ps2}");
Console.WriteLine($"ps1 / ps2 = {ps1 / ps2}");
//Console.WriteLine($"ps1 + 2 = {ps1 + 2}");
/// bai 3 Thêm vào lớp PhanSo các toán tử so sánh. Lưu ý quy tắc “đi theo cặp” bắt buộc của C#.

PhanSo ps_1 = new PhanSo(1, 2);   
PhanSo ps_2 = new PhanSo(2, 4);  
PhanSo ps_3 = new PhanSo(1, 3);  


Console.WriteLine(ps_1 == ps_2);  
Console.WriteLine(ps_1 != ps_3); 
Console.WriteLine(ps_3 < ps_1);  
Console.WriteLine(ps_1 > ps_3);   




app.MapGet("/", () => "PhanSoApp !");
app.Run();
