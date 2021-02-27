<%@ Page Title="Book in   " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebCustomers.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
        <asp:Label ID="NameLabel" runat="server" Text=" Name:"></asp:Label>
        <asp:TextBox ID="NameText" runat="server"  Width="258px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="  Password:"></asp:Label>
        <asp:TextBox ID="PasswordText" runat="server" Width="289px"></asp:TextBox>
        <asp:Button ID="LoginButton" runat="server" Height="38px" Text="Login" Width="156px" OnClick="LoginButton_Click"/>
        <asp:Button ID="RegisteredButton" runat="server" Text="Registered" Height="49px" Width="157px" OnClick="RegisteredButton_Click" />
    </h2>
    <p>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="1">
            <asp:View ID="View1" runat="server">
                <h3>
                First Day<asp:Calendar ID="CalendarFirst" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px"  Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" /> </asp:Calendar>
       
            Last Day
            <asp:Calendar ID="CalendarLast" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" /></asp:Calendar>
                    How many people?<asp:TextBox ID="TextPeople" runat="server"></asp:TextBox>
           <asp:Button ID="ButtonDisponibity" runat="server" Text="View disponibility"  Width="254px" OnClick="ButtonDisponibity_Click"  />

            </h3>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </asp:View>
            <asp:View ID="View3" runat="server">
                
                
                
                <asp:GridView ID="GridViewRooms" runat="server" AutoGenerateSelectButton="True"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
                
                
                
            </asp:View>
        </asp:MultiView>
    </p>
</asp:Content>
