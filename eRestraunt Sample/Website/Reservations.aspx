<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reservations.aspx.cs" Inherits="Reservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>List Reservations By Special Event</h1>
    </div>

    <label>Special Events</label>
    <asp:DropDownList ID="SpecialEventDropDown" runat="server"
        DataSourceID="SpecialEventDataSource"
        DataTextField="Description" DataValueField="EventCode"
        AppendDataBoundItems="True">
    </asp:DropDownList>
    <asp:Button ID="ListReservations" runat="server" Text="View Reservations" />

    <h2>Reservations:</h2>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ListForReservations" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ReservationID" HeaderText="ReservationID" SortExpression="ReservationID"></asp:BoundField>
            <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName"></asp:BoundField>
            <asp:BoundField DataField="ReservationDate" HeaderText="ReservationDate" SortExpression="ReservationDate"></asp:BoundField>
            <asp:BoundField DataField="NumberInParty" HeaderText="NumberInParty" SortExpression="NumberInParty"></asp:BoundField>
            <asp:BoundField DataField="ContactPhone" HeaderText="ContactPhone" SortExpression="ContactPhone"></asp:BoundField>
            <asp:BoundField DataField="ReservationStatus" HeaderText="ReservationStatus" SortExpression="ReservationStatus"></asp:BoundField>
            <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode"></asp:BoundField>
        </Columns>
    </asp:GridView>

    <asp:ObjectDataSource runat="server" 
        ID="SpecialEventDataSource"
        OldValuesParameterFormatString="original_{0}"
        SelectMethod="ListAllSpecialEvents"
        TypeName="eRestraunt.BLL.RestrauntAdminController"></asp:ObjectDataSource>

    <asp:ObjectDataSource runat="server"
        ID="ListForReservations"
        OldValuesParameterFormatString="original_{0}"
        SelectMethod="ListReservationsBySpecialEvent"
        TypeName="eRestraunt.BLL.ReservationController">
        <SelectParameters>
            <asp:ControlParameter ControlID="SpecialEventDropDown" Name="EventID" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>