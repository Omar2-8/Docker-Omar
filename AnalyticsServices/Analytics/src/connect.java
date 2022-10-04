import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class connect {

    public static void main(String[] args) {

        String url ="jdbc:sqlserver:OMAR//SQLEXPRESS;DatabaseName=DataEntry";

        try {
            Connection connection = DriverManager.getConnection(url,"omar","omar");

        }catch (SQLException e){
            System.out.println("errrr");
            System.out.println(e);


        }
    }
}
