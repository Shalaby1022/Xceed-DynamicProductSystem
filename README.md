# **Product Catalog Web Application**

## **Description**
The **XceedBookly** is a system designed to manage and display products based on their availability during specific durations. The application supports **role-based access** for Admins and Customers, ensuring a secure and streamlined experience. Developed using modern web technologies, the app is tailored for robust performance and ease of use.

---
## **Table of Contents**
1. [User Journey](#user-journey)
2. [Features Implemented](#features-implemented)
3. [Enhanced Features & Mitigations](#enhanced-features--mitigations)
4. [Technologies Used](#technologies-used)
5. [Technical Documentation](#technical-documentation)
6. [Screen Recording of the System](#screen-recording-of-the-system)
7. [How to Run the System](#how-to-run-the-system)
---
## **User Journey**

### **Identity Registration**
- Users can register with a **form** that includes:
  - **Client-Side and Server-Side Validation** for fields like:
    - Email
    - Password and Confirm Password
    - Name
    - Street, Address, City, Postal Code
    - Role selection via a dropdown menu (**Admin** or **Customer**).

### **Customer Journey**
1. **Registration**:
   - Registers as a **Customer**.
   - Redirected to the **Home Page** that displays:
     - Only products **currently available** based on the current time.
2. **Browsing Products**:
   - Can navigate to a **Details View** of a product.
   - See product details like name, price, and description.
   - Select the **quantity** they wish to purchase (add-to-cart functionality is not yet implemented).

### **Admin Journey**
1. **Registration**:
   - Registers as an **Admin**.
   - Gains access to additional **content management features**.
2. **Navigation**:
   - The navbar includes a **dropdown menu** labeled "Content Management" with options for:
     - **Categories** (CRUD operations on product categories).
     - **Products** (CRUD operations on products).
3. **Product Management**:
   - Can view a complete list of **all products**, regardless of their availability.
   - Perform the following actions:
     - **Insert Products** with a notification for successful creation.
     - **Delete Products** with a **Sweet Alert** confirmation prompt.
     - **Edit Products**.
     - **Upload Product Images** dynamically using a file upload form.
     - **Delete and Replace Product Images** seamlessly.

---

## **Features Implemented**
### **Customer Features**
- View **currently available products** based on time and duration.
- **Product Details View** to explore additional information about available products.
- **Wild Card Search** for quick product lookups.
- **Pagination** for easy navigation through product lists.
- **Client-Side Validation** using JavaScript.

### **Admin Features**
- **Product Management**:
  - View all products (available and unavailable).
  - Add, edit, and delete products.
  - Manage product images dynamically (upload/edit/delete).
- **Category Management**: Organize products under predefined categories (seeded).
- **Enhanced Search & Filtering**:
  - Filter products by category.
  - Perform wild card searches.
- **Notification System**:
  - Real-time feedback with **Toastr Notifications** and **Sweet Alerts**.

---

## **Enhanced Features & Mitigations**
- **UI Enhancements**:
  - Styled with **Bootswatch Themes** for a modern look.
  - Integrated **Bootswatch Icons** for intuitive navigation.
- **Dynamic File Management**:
  - Product images handled securely using dynamic file uploads (not static).
- **Improved Security**:
  - Role-based access control with **ASP.NET Identity**.
  - Mitigated unauthorized access through strict privilege checks.
- **Error Handling**:
  - Robust error handling across the application for seamless user experience.

---

## **Technologies Used**

| **Technology**       | **Purpose**                                   |
|-----------------------|-----------------------------------------------|
| **C#**               | Core programming language for backend.        |
| **.NET Core MVC**     | Framework for application architecture.       |
| **Entity Framework Core** | ORM for database interaction.             |
| **LINQ**             | Query language for efficient data retrieval.  |
| **MSSQL (via SSMS)**  | Database management.                         |
| **JavaScript**        | Client-side functionality and validation.     |
| **Bootstrap**         | Frontend styling and responsive design.       |
| **Bootswatch**        | Themes for enhanced UI.                      |
| **jQuery**            | Simplified DOM manipulation and AJAX.         |

---

## **Technical Documentation**  
📑 Access the full **[Technical Documentation](https://github.com/Shalaby1022/Xceed-DynamicProductSystem/blob/main/Technical%20Documentation.pdf)** for an in-depth explanation of the application's architecture, design choices, and best practices.

---

## **Screen Recording of the System**
🎥 Watch the system in action with this **[Screen Recording](#)** showcasing all functionalities.

---

### **How to Run the System**

1. **Navigate to the Project Folder**:
   cd XceedTasAppDev
2. **Update DataBase Connection String**: Open appsettings.json and set the connection string for your SQL Server.
3. **Run Migrations** : 
                   dotnet ef migrations add InitialMigration
                   dotnet ef database update
4. **Start the Application** : 
                   dotnet run


