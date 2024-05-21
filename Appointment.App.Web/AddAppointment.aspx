<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAppointment.aspx.cs" Inherits="Appointment.App.Web.AddAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row col-3">
            <div class="row">
                <asp:Label ID="userNameLabel" for="userNameTxt" runat="server">Gebruiker</asp:Label>
                <asp:TextBox ID="userNameTxt" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Label ID="descriptionLabel" runat="server" />
                <asp:TextBox ID="descriptionTxt" runat="server" Rows="3" />
            </div>
            <div class="row">
                <asp:Calendar ID="dateCalendar" runat="server" />
            </div>

            <div class="row">
                <asp:Label ID="appointmentWithLabel" runat="server" />
                <asp:TextBox ID="appointmentWithTxt" runat="server" />
            </div>
            <div class="row">
                <asp:Button ID="saveBtn" Text="Opslaan"  runat="server" OnClick="saveBtn_Click"/>
            </div>
        </div>
</asp:Content>
