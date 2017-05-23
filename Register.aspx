<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>Register</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <!--<link href="http://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet" type="text/css"> -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/ss1.css" rel="stylesheet" />
    <link href="css/ss2.css" rel="stylesheet" />
</head>
    
<body>
<br /><br /><br />
       
    <div class="row">
        <div class="container"> 
            <div class="login-register-form-section">
                <ul class="nav nav-tabs" role="tablist">
                    <li class="active"><a href="#register">Register</a></li>
                </ul>
                <div class="tab-content"><!--
                    <div role="tabpanel" class="tab-pane fade in active" id="login">
                        <form class="form-horizontal" method="post" action="">
                            <div class="form-group " >
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" name="login_email" class="form-control" placeholder="Username or email" required="required" value="">
                                </div>
                            </div>
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-key"></i></div>
                                    <input type="password" name="login_password" class="form-control" placeholder="Password" required="required">
                                </div>
                            </div>
                            <div class="form-group">
                                <input type="checkbox" id="rememberMe">
                                <label for="rememberMe">Remember Me</label>
                                <a href="#" class="pull-right">Forgot password?</a>
                            </div>  
                            <input type="submit" value="Login" class="btn btn-success btn-custom">

                        </form>
                    </div> -->
                    <div role="tabpanel" class="tab-pane fade in active" id="register">
                        <form id="form1" runat="server" class="form-horizontal" method="post" action="Register.aspx.cs">
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" name="lastname" class="form-control" placeholder="Username" required="required" value=""/>
                                </div>
                            </div>

                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" name="lastname" class="form-control" placeholder="Password" required="required" value=""/>
                                </div>
                            </div>


                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" name="firstname" class="form-control" placeholder="Firstname" required="required" value=""/>
                                </div>
                            </div>
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" name="middle" class="form-control" placeholder="Middle" required="required" value=""/>
                                </div>
                            </div>
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" name="lastname" class="form-control" placeholder="Lastname" required="required" value=""/>
                                </div>
                            </div>
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-home"></i></div>
                                    <input type="text" name="address" class="form-control" placeholder="Address" required="" value=""/>
                                </div>
                            </div>
                        
                                                      <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-venus-mars"></i></div>
                                    <input type="text" name="gender" class="form-control" placeholder="Gender" required="required" value=""/>
                                </div>
                            </div>
                         
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-envelope"></i></div>
                                    <input type="email" name="email" class="form-control" placeholder="Email" required="required" value=""/>
                                </div>
                            </div>
                            
                            <input type="submit" value="Submit" class="btn btn-success btn-custom"/>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
<script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

</body>
</html>