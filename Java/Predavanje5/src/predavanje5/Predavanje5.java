package predavanje5;
class character{
    String name;
    String nation;
    String speciality;
    int level;
    int killcount;
    boolean premium;

    public character(String name, String speciality, int level, boolean premium) 
    {
        this.name = name;
        this.speciality = speciality;
        this.level = level;
        this.premium = premium;
    }
    
    void lvlup() {
    level += 1;
    }

    @Override
    public String toString() {
        return "character{" + "name=" + name + ", nation=" + nation + ", speciality=" + speciality + ", level=" + level + ", killcount=" + killcount + ", premium=" + premium + '}';
    }
    
    void rename (String x){
        name = x;
    }
    
}
public class Predavanje5 {
    public static void main(String[] args) {
        character c1 = new character("Zentry", "Warrior", 130, false);
        character c2 = new character("Killation", "Priest", 92, false);
        
        c1.lvlup();
        System.out.println("You have advanced to lvl " + c1.level);
        c2.rename("Svestenik");
        System.out.println(c2.name);
        
    }
    
}
