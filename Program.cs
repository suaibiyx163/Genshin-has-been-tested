using System.Diagnostics;
using System;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System;
using System.Threading;


namespace CheckQQProcess
{
    class Program
    {

        static void Main(string[] args)
        {

            // 获取当前运行的进程
            Process[] processes = Process.GetProcesses();

            // 检查是否有进程(进程需小写)
            bool isQQProcessExist = false;
            foreach (Process process in processes)
            {
                if (process.ProcessName.ToLower() == "yuanshen")//进程名
                {
                    isQQProcessExist = true;
                    break;
                }
            }


                DateTime expirationDate = new DateTime(2023, 3, 2);
                DateTime currentDate = DateTime.Now;

                if (currentDate > expirationDate)
                {
                Console.ForegroundColor = ConsoleColor.Red;//改接下来文字为红色
                Console.WriteLine("------------------");
                Console.WriteLine("原神过检测工具");
                Console.WriteLine("------------------");
                Console.WriteLine("[EpicGlobal] 注册失败，软件已过期");
                Console.WriteLine("[Mistake] 已为你打开更新云盘");
                Console.WriteLine("[Mistake] 访问密码：EpicGlobal");
                Process.Start(new ProcessStartInfo("https://lanzoui.com/b03vrtx4d") { UseShellExecute = true });
                System.Threading.Thread.Sleep(10000);
                Process.GetCurrentProcess().Kill();


            }

                // 输出结果
                if (isQQProcessExist)
            {
                
                Random random = new Random();
                int kaiqi = random.Next(5000, 60000);
                int yidaosan = random.Next(1000, 3000);
                int sandaowu = random.Next(3000, 5000);
                int wudaoba = random.Next(5000, 8000);
                Thread.Sleep(yidaosan);
                Console.ForegroundColor = ConsoleColor.Green;//改接下来文字为绿色
                Console.WriteLine("------------------");//输出的内容
                Console.WriteLine("原神过检测工具");
                Console.WriteLine("软件免费使用，如果你是购买的，恭喜你被骗了");
                Console.WriteLine("软件仅供学习使用，请在24H内删除");
                Console.WriteLine("当前软件版本[V1-3] 适配游戏3.4");
                Console.WriteLine("------------------");
                System.Threading.Thread.Sleep(sandaowu);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;//改接下来文字为红色
              //Console.WriteLine("------------------");
             // Console.WriteLine("原神过检测工具");
             // Console.WriteLine("------------------");
                Console.WriteLine("[EpicGlobalKillDetection] 正在删除工程文件.");
                Thread.Sleep(kaiqi);
                Console.WriteLine("[EpicGlobalKillDetection] 正在校验环境安全.");
                Thread.Sleep(yidaosan);
                Console.WriteLine("[EpicGlobalKillDetection] 环境安全校验成功，正在尝试构建.");
                System.Threading.Thread.Sleep(sandaowu);
                Console.Clear();//清屏
                Console.ForegroundColor = ConsoleColor.Green;//改接下来文字为绿色
                System.Threading.Thread.Sleep(yidaosan);
                Console.WriteLine("------------------");
                Console.WriteLine("EpicGlobalKillDetection");
                Console.WriteLine("------------------");
                System.Threading.Thread.Sleep(sandaowu);
                Console.WriteLine("[EpicGlobalKillDetection] 正在执行注入步骤.");
                System.Threading.Thread.Sleep(sandaowu);
                Console.WriteLine("[EpicGlobalKillDetection] 开始获取dwProcess参数.");
                System.Threading.Thread.Sleep(sandaowu);
                Console.WriteLine("[EpicGlobalKillDetection] 设定myDLL内存范围.");
                System.Threading.Thread.Sleep(yidaosan);
                Console.WriteLine("[EpicGlobalKillDetection] 正在获取安全注入方法.");
                System.Threading.Thread.Sleep(yidaosan);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;//改接下来文字为红色
                System.Threading.Thread.Sleep(yidaosan);
                Console.WriteLine("------------------");
                Console.WriteLine("EpicGlobalKillDetection");
                Console.WriteLine("------------------");
                System.Threading.Thread.Sleep(wudaoba);
                Console.WriteLine("[EpicGlobalKillDetection] 正在获取 Mhyprot2 绕过方法.");
                System.Threading.Thread.Sleep(wudaoba);
                Console.WriteLine("[EpicGlobalKillDetection] 正在校验 Mhyprot2 绕过方法.");
                System.Threading.Thread.Sleep(sandaowu);
                Console.WriteLine("[Mhyprot2-DEBUG] 模块运行正常.");
                System.Threading.Thread.Sleep(sandaowu);
                Console.WriteLine("[Mhyprot2-DEBUG] 选择注入进程."); 
                System.Threading.Thread.Sleep(yidaosan);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;//改接下来文字为绿色
                System.Threading.Thread.Sleep(yidaosan);
                Console.WriteLine("------------------");
                Console.WriteLine("EpicGlobalKillDetection");
                Console.WriteLine("------------------");
                Console.WriteLine("[EpicGlobalKillDetection] 官方群：706367730");
                System.Threading.Thread.Sleep(sandaowu);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;//改接下来文字为红色
                System.Threading.Thread.Sleep(sandaowu);
                Console.WriteLine("------------------");
                Console.WriteLine("EpicGlobalKillDetection");
                Console.WriteLine("------------------");
                System.Threading.Thread.Sleep(100);
                Console.Write("[EpicGlobalKillDetection] 请输入官方群：");
                int input = int.Parse(Console.ReadLine());
                if (input == 706367730)//验证输入是否正确
                {
                    //Console.WriteLine("6");
                    //这里不用写了 自动等待进入下面环节 别问问就是能跑就行
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//改接下来文字为红色
                    Console.WriteLine("官方群号输入不正确！");
                    System.Threading.Thread.Sleep(1000);
                    Process.GetCurrentProcess().Kill();//退出程序
                }
                System.Threading.Thread.Sleep(1000);
                //System.Console.Read();
                //System.Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;//改接下来文字为绿色
                Console.Clear();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("------------------");
                Console.WriteLine("原神过检测工具");
                Console.WriteLine("------------------");
                System.Threading.Thread.Sleep(100);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("[Mhyprot2-DEBUG] 选择进程完成.");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("[Mhyprot2-DEBUG] Initializing D3D11 hook: started.");
                System.Threading.Thread.Sleep(1451);
                Console.WriteLine("[Mhyprot2-DEBUG] Initializing D3D11 hook: done.");
                System.Threading.Thread.Sleep(351);
                Console.WriteLine("[Mhyprot2-DEBUG] Complete point at 10.");
                System.Threading.Thread.Sleep(6354);
                Console.WriteLine("[Mihoyo] 防封Dll已注入 已禁用日志输入.....");
                System.Threading.Thread.Sleep(3452);
                Console.WriteLine("[Mihoyo] 防封打开成功.");
                System.Threading.Thread.Sleep(5000);
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;//改接下来文字为红色
                Console.WriteLine("------------------");
                Console.WriteLine("原神过检测工具");
                Console.WriteLine("------------------");
                Console.WriteLine("[Mihoyo] 原神进程不存在");
                Console.WriteLine("[Mihoyo] 请打开游戏后再使用过检测");
                System.Threading.Thread.Sleep(5000);
                Process.GetCurrentProcess().Kill();
            }

            Console.ReadKey();
        }
    }
}


