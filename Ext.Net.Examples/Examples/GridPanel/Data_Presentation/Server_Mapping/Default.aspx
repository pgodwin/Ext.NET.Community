<%@ Page Language="C#" %>

<%@ Import Namespace="System.Collections.Generic" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        var store = this.GridPanel1.GetStore();
        
        store.DataSource = Employee.GetAll();
        store.DataBind();
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Department Department { get; set; }

        public static List<Employee> GetAll()
        {
            return new List<Employee>
            {
               new Employee
               {
                   ID = 1,
                   Name = "Nancy",
                   Surname = "Davolio",
                   Department = Department.GetAll()[0]
               },
               new Employee
               {
                   ID = 2,
                   Name = "Andrew",
                   Surname = "Fuller",
                   Department = Department.GetAll()[2]
               }
            };
        }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Department> GetAll()
        {
            return new List<Department>
            {
                new Department { ID = 1, Name = "Department A" },
                new Department { ID = 2, Name = "Department B" },
                new Department { ID = 3, Name = "Department C" }
            };
        }
    }
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Server Mapping - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        
        <ext:GridPanel
            ID="GridPanel1"
            runat="server"
            EnableViewState="true" 
            AutoHeight="true" 
            Title="List" 
            Icon="Application">
            <Store>
                <ext:Store runat="server">
                    <Reader>
                        <ext:JsonReader IDProperty="ID">
                            <Fields>
                                <ext:RecordField Name="ID" Type="Int" />
                                <ext:RecordField Name="Name" />
                                <ext:RecordField Name="Surname" />
                                <ext:RecordField Name="Department" ServerMapping="Department.Name" />
                            </Fields>
                        </ext:JsonReader>
                    </Reader>
                </ext:Store>
            </Store>
            <ColumnModel runat="server">                
                <Columns>
                    <ext:Column Header="ID" DataIndex="ID" />
                    <ext:Column Header="NAME" DataIndex="Name" />
                    <ext:Column Header="SURNAME" DataIndex="Surname" />
                    <ext:Column DataIndex="Department" Header="Department" Width="240" />
                </Columns>
            </ColumnModel>
            <SelectionModel>
                <ext:RowSelectionModel runat="server" />
            </SelectionModel>
            <LoadMask Msg="Loading" ShowMask="true" />
        </ext:GridPanel>
    </form>
</body>
</html>
