using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService (SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departament.Any()||
            _context.Seller.Any()||
            _context.SalesRecord.Any())
            {
                return; // DB has been Seeded
            }
            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");
                                  
            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998,4,21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979,12,31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988,1,15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993,11,30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000,1,9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "pink@gmail.com", new DateTime(1997,3,4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 08, 24), 8000.0, Models.Enums.SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 07, 23), 22000.0, Models.Enums.SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 06, 22), 5000.0, Models.Enums.SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 05, 21), 1000.0, Models.Enums.SalesStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 04, 19), 12000.0, Models.Enums.SalesStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 03, 18), 21000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 02, 15), 2000.0, Models.Enums.SalesStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 01, 14), 2500.0, Models.Enums.SalesStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 12, 13), 3500.0, Models.Enums.SalesStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 11, 12), 8700.0, Models.Enums.SalesStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 10, 11), 12000.0, Models.Enums.SalesStatus.Billed, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 10), 10000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 08, 9), 11000.0, Models.Enums.SalesStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 07, 8), 11000.0, Models.Enums.SalesStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 06, 7), 11000.0, Models.Enums.SalesStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 05, 6), 11000.0, Models.Enums.SalesStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 04, 24), 11000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 03, 30), 11000.0, Models.Enums.SalesStatus.Billed, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 02, 27), 11000.0, Models.Enums.SalesStatus.Billed, s3);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 01, 28), 31000.0, Models.Enums.SalesStatus.Billed, s4);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 12, 27), 41000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 11, 26), 51000.0, Models.Enums.SalesStatus.Billed, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 25), 61000.0, Models.Enums.SalesStatus.Billed, s3);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 09, 23), 71000.0, Models.Enums.SalesStatus.Billed, s4);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 08, 22), 81000.0, Models.Enums.SalesStatus.Billed, s5);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 07, 21), 91000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 08, 22), 11000.0, Models.Enums.SalesStatus.Billed, s2);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 07, 18), 11000.0, Models.Enums.SalesStatus.Billed, s3);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 06, 03), 11000.0, Models.Enums.SalesStatus.Billed, s4);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1,s2,s3,s4,s5,s5);
            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,
                r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30);

            _context.SaveChanges();
        }
     }
}
