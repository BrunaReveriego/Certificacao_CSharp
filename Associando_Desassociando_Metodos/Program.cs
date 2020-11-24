using System;

namespace _01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou -= CampainhaTocou1;
            //campainha.OnCampainhaTocou -= CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();



            Console.ReadKey();

        }

        static void CampainhaTocou1()
        {
            Console.WriteLine("Ding dong! (1).");
        }


        static void CampainhaTocou2()
        {
            Console.WriteLine("Ding dong! (2).");
        }


    }

    class Campainha
    {
        //Action -> ponteiro para função sem retorno

        public Action OnCampainhaTocou { get; set; }

        public void Tocar()
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou();
            }


        }

    }
}
