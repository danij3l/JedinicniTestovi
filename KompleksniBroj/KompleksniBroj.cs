using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom
{
    public struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni)
        {
            realniDio = realni;
            imagrinarniDio = imaginarni;
        }

        public double realniDio;
        public double imagrinarniDio;

        public static KompleksniBroj operator+(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.realniDio + br2.realniDio, br1.imagrinarniDio + br2.imagrinarniDio);
        }

        public static KompleksniBroj operator -(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.realniDio - br2.realniDio, br1.imagrinarniDio - br2.imagrinarniDio);
        }

    }
}
