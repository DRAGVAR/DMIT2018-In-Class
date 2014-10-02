<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuItems.aspx.cs" Inherits="MenuItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<%--Original Menu Repeater That Showed Item Entities
    <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource">
        <ItemTemplate>
            <%# ((decimal)Eval("CurrentPrice")).ToString("C") %>
            &mdash; <%# Eval("Description") %> &ndash; <%# Eval("Category.Description") %>
            &ndash; <%# Eval("Calories") %> Calories
        </ItemTemplate>
        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>
    </asp:Repeater>--%>
    <div class="row col-md-12">
        <h1>Our Menu Items</h1>
        <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource">
            <ItemTemplate>
                <h3>
                    <img src='<%# "Images/" + Eval("Description") + "-1.png" %>' alt="" />
                        <%# Eval("Description") %>
                </h3>
                <div class="well">
                    <asp:Repeater ID="ItemDetailRepeater" runat="server" DataSource='<%# Eval("MenuItems") %>'>
                        <ItemTemplate>
                            <div>
                                <h4>
                                    <%# Eval("Description") %>
                                    <span class="badge"><%# Eval("Calories") %> Calories</span>
                                    <%# ((decimal)Eval("Price")).ToString("C") %>
                                    <%# Eval("Comment") %>
                                </h4>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </ItemTemplate>
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
        </asp:Repeater>
    </div>

    <asp:ObjectDataSource runat="server" ID="MenuItemDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCategorizedMenuItems" TypeName="eRestraunt.BLL.MenuController"></asp:ObjectDataSource>
</asp:Content>

