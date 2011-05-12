<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="c#" AutoEventWireup="true" 
Inherits="nothinbutdotnetstore.web.ui.views.ProductBrowser"
CodeFile="ProductBrowser.aspx.cs" MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.web.application.catalogbrowsing" %>

<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <form></form>
   <table>            
   <panel>List of department products</panel>
              <%-- for each department --%>
              <% foreach (var product in ((IEnumerable<ProductItem>)this.Context.Items["blah"]))
                 {%>
                <tr class="ListItem">
                 <td><a href="#"><%= product.name %></a></td>
             	  </tr>        

                <%
                 }%>
      	    </table>      
		</asp:Content>
