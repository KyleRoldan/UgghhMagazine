import { useState, useEffect } from "react";
import "../../views/viewsCss/LatestPost.css";
import { getPostById } from "../../../managers/PostManager";
import { Link, useParams } from "react-router-dom";

export default function PostDetails() {
  const { id } = useParams();
  const [post, setPost] = useState(null);

  
  

  useEffect(() => {
        getPostById(id).then(setPost);
       }, [id]);

  if (!post) {
    return (
      <>

      <div className="opinion">
        <h2>postDetails</h2>
        <div>No Post Detected</div>
        
        
      </div>
      </>
    );
  }
  return (
    <>



<div className="opinion">
      <h2>Post Details</h2>

      <div>              
      <Link to={`/post/${id}/update`}>
              <button >
                    Edit
                  </button></Link>
                </div>
      <div>
        <div>

          <div>{post.title}</div>
          <div>Author: {post.author}</div>
          <div>Category: {post.category.name}</div>
          <div>Date: {post.date}</div>
          
        </div>
      </div>



      <h4>Body of Text</h4>
      <div>Content: {post.content}</div>
      
     </div>
    </>
  );
}




// export default function AppointmentDetails() {
//     const { id } = useParams();
//     const [appointment, setAppointment] = useState(null);
  
//     useEffect(() => {
//       getAppointment(id).then(setAppointment);
//     }, [id]);
  
//     if (!appointment) {
//       return null;
//     }
  
//     // Calculate total cost by summing up prices of associated services
//     const totalCost = appointment.appointmentServices.reduce(
//       (sum, service) => sum + (service.service?.price || 0),
//       0
//     );
  
//     return (
//       <div className="container">
//         <h2>{`${appointment.customer.firstName} ${appointment.customer.lastName}'s Appointment`}</h2>
//         <Table>
//           <tbody>
//             <tr>
//               <th scope="row">With Stylist:</th>
//               <td>{`${appointment.stylist.firstName} ${appointment.stylist.lastName}`}</td>
//             </tr>
//             <tr>
//               <th scope="row">Time:</th>
//               <td>{appointment.startDate}</td>
//             </tr>
//             <tr>
//               <th scope="row">Services:</th>
//               <td>
//                 {appointment.appointmentServices.map((service) => (
//                   <div key={service.id}>
//                     {`${service.service?.name} - $${service.service?.price}`}
//                   </div>
//                 ))}
//               </td>
//             </tr>
//             <tr>
//               <th scope="row">Total Cost:</th>
//               <td>${totalCost}</td>
//             </tr>
//           </tbody>
//         </Table>
//       </div>
//     );
//   }
  