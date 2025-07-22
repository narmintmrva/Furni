# 🛍️ Shopping App (Furni.)

A modern full-stack shopping web application with user-facing e-commerce functionality and a robust admin dashboard. Built with .NET 8, this platform allows users to browse categorized furniture, add to cart, proceed with Stripe checkout, and offers admin/staff full control over content and users.

---

## 🚀 Features

### 🛒 User-Side (Shop)
- View all products with **pagination**
- **Categorized search** via clickable buttons (e.g., Couches, Sofas)
- **Product detail and pricing**
- Add items to **shopping cart**
- Adjust item **quantity**
- **Stripe checkout** integration
- Send **message** to admin for contact

### 🔧 Admin Dashboard
- Full **CRUD** for:
  - Products
  - Categories
  - Blogs
  - Orders
- **User management**:
  - Roles (Admin, Staff, Member)
  - Activate/Deactivate users
  - Reset password (using email)
- **Authentication & Authorization**

---

## 🛠 Tech Stack

- ASP.NET Core (.NET 8)
- Entity Framework Core
- MSSQL Server
- Stripe API
- Identity (Authentication & Authorization)
- Email Service
- Swagger
- JQuery

---

## 🔧 Setup Instructions

1. **Clone the repository**

   ```bash
   git clone https://github.com/yourusername/shopping-app.git
   cd shopping-app

3. **Configure your database** - Update your connection string in `appsettings.json`

3. **Run migrations**

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update

5. **Setup Stripe** - Add your Stripe public/secret keys to `appsettings.json`
   
7. **Run the project**

    ```bash
    dotnet run

9. **Visit the app** - Navigate to `https://localhost:5001` or `http://localhost:5000`

## 📝 License
MIT – Use freely for learning or building upon
