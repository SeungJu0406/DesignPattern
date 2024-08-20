using System.Text;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 체인 메소드
            StringBuilder sb = new StringBuilder();
            sb.Append("안").Append("녕").Append("하세요");
            string Hi = sb.ToString();


            OrcBuilder warriorOrcBuilder = new OrcBuilder();
            warriorOrcBuilder
                .SetName("오크 전사")
                .SetArmor("갑옷");

            Orc warriorOrc1 = warriorOrcBuilder.Build();

            warriorOrcBuilder.SetWeapon("도끼");

            Orc warriorOrc2 = warriorOrcBuilder.Build();

            OrcBuilder archorOrcBuild = new OrcBuilder();
            archorOrcBuild.SetName("오크 궁수");
            archorOrcBuild.SetWeapon("활");

            Orc archorOrc = archorOrcBuild.Build();

            OrcBuilder shamanOrcBuilder = new OrcBuilder();
            shamanOrcBuilder.SetName("오크 주술사");
            shamanOrcBuilder.SetWeapon("지팡이");

            Orc shamenOrc = shamanOrcBuilder.Build();
        }
    }

    public class OrcBuilder
    {
        public string name;
        public string weapon;
        public string armor;

        // 기본값
        public OrcBuilder()
        {
            name = "오크";
            weapon = "몽둥이";
            armor = "천옷";
        }

        public Orc Build()
        {
            Orc orc = new Orc();
            orc.name = name;
            orc.weapon = weapon;  
            orc.armor = armor;
            return orc;
        }

        // 이름 제작 함수
        public OrcBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        //무기 제작 함수
        public OrcBuilder SetWeapon(string weapon)
        {
            this.weapon = weapon;
            return this;
        }
        //방어구 제작 함수
        public OrcBuilder SetArmor(string armor)
        {
            this.armor = armor;
            return this;
        }
    }
    public class Orc
    {
        public string name;
        public string weapon;
        public string armor;
    }
}
