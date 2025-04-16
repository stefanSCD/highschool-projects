// src/services/authService.js

// Funcție pentru login
export const loginUser = async (email, password) => {
    try {
      const response = await fetch('http://localhost:5000/api/auth/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ email, password })
      });
      
      const data = await response.json();
      
      if (response.ok) {
        // Salvează token-ul în localStorage
        localStorage.setItem('token', data.token);
        return data.user;
      } else {
        throw new Error(data.message);
      }
    } catch (error) {
      console.error('Login error:', error);
      throw error;
    }
  };
  
  // Funcție pentru înregistrare
  export const registerUser = async (userData) => {
    try {
      const response = await fetch('http://localhost:5000/api/auth/register', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(userData)
      });
      
      const data = await response.json();
      
      if (response.ok) {
        // Salvează token-ul în localStorage
        localStorage.setItem('token', data.token);
        return data;
      } else {
        throw new Error(data.message);
      }
    } catch (error) {
      console.error('Registration error:', error);
      throw error;
    }
  };
  
  // Funcție pentru a verifica dacă utilizatorul e autentificat
  export const isAuthenticated = () => {
    return localStorage.getItem('token') !== null;
  };
  
  // Funcție pentru logout
  export const logoutUser = () => {
    localStorage.removeItem('token');
  };
  
  // Funcție pentru a obține utilizatorul curent
  export const getCurrentUser = async () => {
    try {
      const token = localStorage.getItem('token');
      if (!token) return null;
      
      const response = await fetch('http://localhost:5000/api/users/me', {
        headers: {
          'x-auth-token': token
        }
      });
      
      const data = await response.json();
      
      if (response.ok) {
        return data;
      } else {
        throw new Error(data.message);
      }
    } catch (error) {
      console.error('Get current user error:', error);
      return null;
    }
  };