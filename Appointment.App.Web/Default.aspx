<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Appointment.App.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Button ID="addBtn" Text="Afspraak toevoegen" runat="server" OnClick="addBtn_Click"/>
         <asp:GridView runat="server" ID="appointmentsGrid"
        ItemType="Appointment.App.Models.AppointmentModel" DataKeyNames="Id" 
        SelectMethod="appointmentsGrid_GetData"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="Id" />
            <asp:DynamicField DataField="UserName" />
            <asp:DynamicField DataField="Description" />
            <asp:DynamicField DataField="Date" />
            <asp:DynamicField DataField="Location" />
            <asp:DynamicField DataField="AppointmentWith" />
            <asp:DynamicField DataField="Location" />
          </Columns>
    </asp:GridView>
    </main>

</asp:Content>
