     <?php 
            session_start();
            include_once('view.php');
            $result511 = $connect->query("SELECT * FROM crime_report");

            if(isset($_POST["sub"]))
{

$name1="Complaint CLosed for Further Details visit Nearest Station";
$sql = "UPDATE crime_report SET cstatus='$name1' WHERE id='$_POST[didval]'";

  if($connect->query($sql) === TRUE) {

           $sql = "SELECT * FROM crime_report  WHERE id='$_POST[didval]'";
$result = $connect->query($sql);
require 'class/class.phpmailer.php';
  $output = '';
 foreach ($result as $data) {
      ?> 
      <?php 
      
  

    $txt="Complaint Status Notificaction";
    
    $mail = new PHPMailer;
    $mail->IsSMTP();                //Sets Mailer to send message using SMTP
    $mail ->Host = "smtp.gmail.com";
      $mail ->Port = 465; // or 587
      $mail->SMTPAuth = true;             //Sets SMTP authentication. Utilizes the Username and Password variables
     $mail ->Username = "example@gmail.com";
   $mail ->Password = "example";
     $mail->SMTPSecure = 'ssl';             //Sets connection prefix. Options are "", "ssl" or "tls"
    //$mail->From = 'info@webslesson.com';      //Sets the From email address for the message
    //$mail->FromName = 'Webslesson';         //Sets the From name of the message
     $mail ->SetFrom("example@gmail.com","yourname");
    $mail->AddAddress($data["email"], $data["name"]); //Adds a "To" address
    $mail->WordWrap = 50;             //Sets word wrapping on the body of the message to a given number of characters
    $mail->IsHTML(true);              //Sets message type to HTML
    //$mail->Subject = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit'; //Sets the Subject of the message
    //An HTML or plain text message body
    $mail->Subject = $txt;
    $mail->Body = $name1;
    
    $mail->AltBody = '';

    $result = $mail->Send();            //Send an Email. Return true on success or false on error

    if($result["code"] == '400')
    {
      $output .= html_entity_decode($result['full_error']);
    }
     
    header("Location: view_crime.php");
    exit();
  }  
}
}
            
    ?>
   

 <!DOCTYPE html>
<html>
<head>
<title>View crime</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link href="../layout/styles/main.css" rel="stylesheet" type="text/css" media="all">
<link href="../layout/styles/mediaqueries.css" rel="stylesheet" type="text/css" media="all">
<!--[if lt IE 9]>
<link href="../layout/styles/ie/ie8.css" rel="stylesheet" type="text/css" media="all">
<script src="../layout/scripts/ie/css3-mediaqueries.min.js"></script>
<script src="../layout/scripts/ie/html5shiv.min.js"></script>
<![endif]-->
</head>
<body class="">
<div class="wrapper row1">
  <header id="header" class="full_width clear">
    <div id="hgroup">
      <h1><a href="../index.html">Crime Reporting</a></h1>
      <h2>Admin</h2>
    </div>
    <div id="header-contact">
      <ul class="list none">
        <li><span class="icon-envelope"></span> <a href="#">info@domain.com</a></li>
        <li><span class="icon-phone"></span> +xx xxx xxxxxxxxxx</li>
      </ul>
    </div>
  </header>
</div>
<!-- ################################################################################################ -->
<!-- content -->
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <section class="clear">
      <h1>View Complaint</h1>
    </section>
 

    <table align="center" border="1px">
        <tr>
            <th colspan="9"><h2>Record</h2></th>
        </tr>
        <tr>
            <th> Name </th>
            <th> Email </th>
            <th> Phone </th>
            <th> Address </th>
            <th> Attach File </th>
            <th> Crime </th>
            <th> Message </th>
             <th> Status </th>
            <th> Action </th>
        </tr>
    <?php 
        while($rows=mysqli_fetch_array($result511))
        {
    ?>       
            <tr>
                <td><?php echo $rows['name']; ?></td>
                <td><?php echo $rows['email']; ?></td>
                <td><?php echo $rows['phone']; ?></td>
                <td><?php echo $rows['address']; ?></td>
                <td><?php echo $rows['filetoupload']; ?></td>
                <td><?php echo $rows['selected']; ?></td>
                <td><?php echo $rows['message']; ?></td>
                <td><?php echo $rows['cstatus'];?></td>
                <td> 
                <form  method="POST" action="view_crime.php" class="form-horizontal"  enctype="multipart/form-data" >
   
                    <input type='hidden' name='didval' value="<?php echo $rows['id']; ?>" > 

                    <input type="submit" name="sub" class="btn btn-danger" value="Update">
                </form>
               </td>
            </tr>
     
    <?php     
        }
    ?>    
    </table>  

   <div class="wrapper row3">
     <div id="container">
      <p class="clear"><a class="fl_left" href="javascript:history.go(-1)">&laquo; Go Back</a> <a class="fl_right" href="../index.html">Go Home &raquo;</a></p>
      </div>
    </div>
    <!-- ################################################################################################ -->
    <div class="clear"></div>
  </div>
</div>
<!-- Scripts -->
<script src="https://code.jquery.com/jquery-latest.min.js"></script>
<script src="https://code.jquery.com/ui/1.10.1/jquery-ui.min.js"></script>
<script>window.jQuery || document.write('<script src="../layout/scripts/jquery-latest.min.js"><\/script>\
<script src="../layout/scripts/jquery-ui.min.js"><\/script>')</script>
<script>jQuery(document).ready(function($){ $('img').removeAttr('width height'); });</script>
<script src="../layout/scripts/jquery-mobilemenu.min.js"></script>
<script src="../layout/scripts/custom.js"></script>
</body>
</html>