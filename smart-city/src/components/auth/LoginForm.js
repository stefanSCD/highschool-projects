import React, { useState } from 'react';
import { Eye, EyeOff, LogIn, Building2 } from 'lucide-react';

const FancyLogin = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    setIsLoading(true);
    setError('');
    
    // Autentificare simplă simulată
    setTimeout(() => {
      // Verifică datele hardcodate
      if (email === 'test@test' && password === 'test') {
        // Simulează stocarea unui token de autentificare
        localStorage.setItem('authToken', 'simulated_token_123');
        localStorage.setItem('user', JSON.stringify({
          name: 'Alex Johnson',
          email: 'test@test'
        }));
        
        // Redirecționează către dashboard
        window.location.href = '/userDashboard';
      } else if (email === 'admin@test' && password === 'admin') {
        // Simulează stocarea unui token de autentificare pentru admin
        localStorage.setItem('authToken', 'admin_token_123');
        localStorage.setItem('user', JSON.stringify({
          name: 'Admin User',
          email: 'admin@test'
        }));
        
        // Redirecționează către dashboard-ul admin
        window.location.href = '/adminDashboard';
      }
      else if (email === 'employee@test' && password === 'test') {
        // Simulează stocarea unui token de autentificare pentru angajat
        localStorage.setItem('authToken', 'employee_token_123');
        localStorage.setItem('user', JSON.stringify({
          name: 'Employee User',
          email: 'employee@test'
        }));
        
        // Redirecționează către dashboard-ul angajatului
        window.location.href = '/employeeDashboard';
      }
      else {
        setError('Invalid email or password');
      }
      setIsLoading(false);
    }, 1000);
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-gradient-to-br from-blue-900 to-indigo-800">
      {/* Codul existent pentru UI */}
      <div className="bg-white bg-opacity-10 backdrop-filter backdrop-blur-lg rounded-xl shadow-2xl p-8 w-full max-w-md z-10">
        <div className="text-center mb-8">
          <div className="flex justify-center mb-4">
            <div className="bg-blue-600 p-3 rounded-full inline-flex">
              <Building2 size={36} className="text-white" />
            </div>
          </div>
          <h2 className="text-3xl font-bold text-white">Smart City</h2>
          <p className="text-blue-200 mt-2">Sign in to access your dashboard</p>
        </div>
        
        {error && (
          <div className="mb-4 p-3 bg-red-500 bg-opacity-25 border border-red-500 rounded-lg text-white text-sm">
            {error}
          </div>
        )}
        
        <form onSubmit={handleSubmit}>
          <div className="space-y-5">
            <div>
              <label className="block text-blue-200 mb-2 text-sm font-medium">Email</label>
              <input
                type="email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                required
                className="w-full px-4 py-3 rounded-lg bg-white bg-opacity-20 border border-blue-300 border-opacity-30 focus:border-blue-400 focus:outline-none text-white placeholder-blue-200"
                placeholder="your.email@example.com"
              />
            </div>
            
            <div>
              <label className="block text-blue-200 mb-2 text-sm font-medium">Password</label>
              <div className="relative">
                <input
                  type={showPassword ? "text" : "password"}
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                  required
                  className="w-full px-4 py-3 rounded-lg bg-white bg-opacity-20 border border-blue-300 border-opacity-30 focus:border-blue-400 focus:outline-none text-white placeholder-blue-200"
                  placeholder="••••••••"
                />
                <button
                  type="button"
                  onClick={() => setShowPassword(!showPassword)}
                  className="absolute right-3 top-1/2 transform -translate-y-1/2 text-blue-200 hover:text-white"
                >
                  {showPassword ? <EyeOff size={18} /> : <Eye size={18} />}
                </button>
              </div>
              <div className="flex justify-end">
                <a href="#" className="text-sm text-blue-300 hover:text-blue-100 mt-2">Forgot password?</a>
              </div>
            </div>
            
            <button
              type="submit"
              disabled={isLoading}
              className="w-full py-3 px-4 bg-gradient-to-r from-blue-500 to-indigo-600 text-white rounded-lg font-medium shadow-lg hover:from-blue-600 hover:to-indigo-700 focus:outline-none focus:ring-2 focus:ring-blue-400 focus:ring-opacity-50 transform transition hover:-translate-y-0.5"
            >
              {isLoading ? (
                <div className="flex items-center justify-center">
                  <div className="animate-spin rounded-full h-5 w-5 border-t-2 border-b-2 border-white mr-2"></div>
                  Signing in...
                </div>
              ) : (
                <div className="flex items-center justify-center">
                  <LogIn size={18} className="mr-2" />
                  Sign in
                </div>
              )}
            </button>
          </div>
        </form>
        
        <div className="mt-6 text-center">
          <p className="text-blue-200">
            Don't have an account? <a href="/signup" className="text-blue-400 hover:text-blue-300 font-medium">Sign up</a>
          </p>
        </div>
        
        {/* Animated pulsing circles in the background */}
        <div className="absolute top-1/4 left-1/4 w-32 h-32 bg-blue-500 rounded-full filter blur-3xl opacity-20 animate-pulse"></div>
        <div className="absolute bottom-1/4 right-1/3 w-40 h-40 bg-indigo-600 rounded-full filter blur-3xl opacity-20 animate-pulse" style={{ animationDelay: '1s' }}></div>
      </div>
    </div>
  );
};

export default FancyLogin;