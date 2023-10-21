using Microsoft.AspNetCore.Mvc;

namespace w2routing.Controllers
{
    [Route("second-controller")]
    public class SecondController : Controller
    {
        [HttpGet("{*url}", Order = int.MaxValue)]
        public String CatchThemAll()
        {
            return "Przechwyciłem odpowiedź ze statusem 404.";
        }

        [HttpGet("stress-test/{limit:int}")]
        public IActionResult TimeConsuming(int limit)
        {
            List<int> resp = new List<int>();
            // int limit = 100;           
            for (int v = 2; resp.Count < limit; v++)
            {
                bool notPrime = false;
                for (int d = 2; d < v - 1; d++)
                {
                    if (v % d == 0)
                    {
                        d = v;
                        notPrime = true;
                    }
                }
                if (!notPrime)
                {
                    resp.Add(v);
                }
            }

            return View(resp);
        }

        [HttpGet("lazy-function/{limit:int}")]
        public async Task<IActionResult> BetterTimeConsuming(int limit)
        {
            return View("TimeConsuming", await lazyFunction(limit));
        }

        [HttpGet("test-cancel")]
        public async Task<string> TestCancel(CancellationToken token)
        {
            await Task.Delay(10_000, token);
            Console.WriteLine("Kiedy to się skonczylo;");
            return "Cokolwiek";
        }


        private async Task<List<int>> lazyFunction(int limit)
        {
            List<int> resp = new List<int>();
            for (int v = 2; resp.Count < limit; v++)
            {
                bool notPrime = false;
                for (int d = 2; d < v - 1; d++)
                {
                    if (v % d == 0)
                    {
                        d = v;
                        notPrime = true;
                    }
                }
                if (!notPrime)
                {
                    resp.Add(v);
                }
            }

            return await Task.FromResult<List<int>>(resp);
        }
    }

}
