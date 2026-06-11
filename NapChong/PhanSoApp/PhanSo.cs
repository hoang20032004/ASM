using System;

namespace PhanSoApp
{
    public class PhanSo
    {
        public int TuSo { get; private set; }
        public int MauSo { get; private set; }

        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
                throw new ArgumentException("Mau so khong duoc bang 0!");

            // Xu ly dau: dua dau am len tu so
            if (mauSo < 0) 
            { 
                tuSo = -tuSo; 
                mauSo = -mauSo; 
            }

            int ucln = UCLN(Math.Abs(tuSo), Math.Abs(mauSo));
            TuSo = tuSo / ucln;
            MauSo = mauSo / ucln;
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0) 
            { 
                int t = b; 
                b = a % b; 
                a = t; 
            }
            return a;
        }

        public PhanSo RutGon()
        {
            return new PhanSo(TuSo, MauSo); // Constructor da tu dong rut gon
        }

        public override string ToString()
        {
            if (MauSo == 1) return TuSo.ToString();
            return $"{TuSo}/{MauSo}";
        }

        // BÀI TẬP 2: Nạp chồng toán tử số học
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.TuSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.TuSo == 0) throw new DivideByZeroException("Khong the chia cho phan so 0.");
            return new PhanSo(a.TuSo * b.MauSo, a.MauSo * b.TuSo);
        }

        // Yêu cầu nâng cao: Cộng phân số với số nguyên
        public static PhanSo operator +(PhanSo a, int b)
        {
            return a + new PhanSo(b, 1);
        }

        public static PhanSo operator +(int a, PhanSo b)
        {
            return new PhanSo(a, 1) + b;
        }

        // BÀI TẬP 3: Nạp chồng toán tử so sánh
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            // Kiểm tra null để tránh vòng lặp đệ quy trong Operator ==
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            
            // Vì đã rút gọn trong constructor nên chỉ cần so sánh tử và mẫu
            return a.TuSo == b.TuSo && a.MauSo == b.MauSo;
        }

        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return !(a == b);
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.MauSo) < (b.TuSo * a.MauSo);
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.MauSo) > (b.TuSo * a.MauSo);
        }

        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.MauSo) <= (b.TuSo * a.MauSo);
        }

        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.MauSo) >= (b.TuSo * a.MauSo);
        }

        // Override Equals() và GetHashCode() theo yêu cầu của C#
        public override bool Equals(object obj)
        {
            if (obj is PhanSo ps)
            {
                return this == ps;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TuSo, MauSo);
        }
    }
}