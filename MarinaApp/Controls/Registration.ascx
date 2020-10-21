<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="MarinaApp.Controls.Registration" %>
<br />
<h3>Registration Add/Update</h3>
	<div class="card" style="margin-left: 40px">		
			<div class="form-group">
	    		<label for="firstname">Firstname:&nbsp; </label>
	    		<asp:TextBox runat="server" type="text" id="txtFirstname" class="form-control" name="firstname" required="required">
					</asp:TextBox>
	  		</div>
	  		<div class="form-group">
	    		<label for="lastname">Lastname:&nbsp; </label>
	    		<asp:TextBox runat="server" type="text" id="txtLastname" class="form-control" name="lastname" required="required">
					</asp:TextBox>
	  		</div>
	  		<div class="form-group">
	    		<label for="phone">Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	    		<asp:TextBox runat="server" type="text" id="txtPhone" class="form-control" name="phone" required="required">
	  		</asp:TextBox>
                </label>
			  </div>
	  		<div class="form-group">
	    		<label for="city">City</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	    		<asp:TextBox runat="server" type="text" id="txtCity" class="form-control" name="city" required="required">
	  		</asp:TextBox>
					<br />
					</div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;	  		
	  		<asp:Button runat="server" type="submit" class="btn btn-primary" value="Click to Submit" onclick="btnSubmit_click" id="btnSubmit" aria-disabled="False" role="button" Text="Submit"></asp:Button>
	  		&nbsp;&nbsp;&nbsp;
	  		<asp:Button runat="server" type="reset" class="btn btn-primary" value="Click to Reset" onclick="btnReset_click" role="button" Text="Reset"></asp:Button>
	</div>
  