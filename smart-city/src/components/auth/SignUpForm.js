import React, { useState } from 'react';
import { Eye, EyeOff, UserPlus, Building2, Check } from 'lucide-react';

const SignUpForm = () => {
  const [fullName, setFullName] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);
  const [isLoading, setIsLoading] = useState(false);
  const [acceptTerms, setAcceptTerms] = useState(false);

  const handleSubmit = (e) => {
    e.preventDefault();
    
    if (password !== confirmPassword) {
      alert('Passwords do not match!');
      return;
    }
    
    if (!acceptTerms) {
      alert('Please accept the terms and conditions');
      return;
    }
    
    setIsLoading(true);
    
    // Simulate sign up process
    setTimeout(() => {
      setIsLoading(false);
      alert('Account created successfully!');
    }, 1500);
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-gradient-to-br from-blue-900 to-indigo-800">
      <div className="absolute inset-0 overflow-hidden">
        {/* City skyline silhouette */}
        <div className="absolute bottom-0 w-full h-64 bg-black bg-opacity-30">
          <div className="relative w-full h-full">
            {Array.from({ length: 20 }).map((_, i) => (
              <div 
                key={i}
                className="absolute bottom-0 bg-gray-800 bg-opacity-70"
                style={{
                  left: `${i * 5}%`,
                  height: `${Math.random() * 50 + 20}%`,
                  width: '3%',
                  borderTopLeftRadius: '4px',
                  borderTopRightRadius: '4px',
                }}
              >
                {/* Windows */}
                {Array.from({ length: Math.floor(Math.random() * 5 + 3) }).map((_, j) => (
                  <div 
                    key={j}
                    className="absolute bg-yellow-400 bg-opacity-70"
                    style={{
                      left: '25%',
                      top: `${j * 20}%`,
                      height: '10%',
                      width: '50%',
                    }}
                  />
                ))}
              </div>
            ))}
          </div>
        </div>
      </div>
      
      <div className="bg-white bg-opacity-10 backdrop-filter backdrop-blur-lg rounded-xl shadow-2xl p-8 w-full max-w-md z-10">
        <div className="text-center mb-6">
          <div className="flex justify-center mb-4">
            <div className="bg-blue-600 p-3 rounded-full inline-flex">
              <Building2 size={36} className="text-white" />
            </div>
          </div>
          <h2 className="text-3xl font-bold text-white">Smart City</h2>
          <p className="text-blue-200 mt-2">Create your account</p>
        </div>
        
        <form onSubmit={handleSubmit}>
          <div className="space-y-4">
            <div>
              <label className="block text-blue-200 mb-2 text-sm font-medium">Full Name</label>
              <input
                type="text"
                value={fullName}
                onChange={(e) => setFullName(e.target.value)}
                required
                className="w-full px-4 py-3 rounded-lg bg-white bg-opacity-20 border border-blue-300 border-opacity-30 focus:border-blue-400 focus:outline-none text-white placeholder-blue-200"
                placeholder="John Doe"
              />
            </div>
            
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
            </div>
            
            <div>
              <label className="block text-blue-200 mb-2 text-sm font-medium">Confirm Password</label>
              <div className="relative">
                <input
                  type={showConfirmPassword ? "text" : "password"}
                  value={confirmPassword}
                  onChange={(e) => setConfirmPassword(e.target.value)}
                  required
                  className="w-full px-4 py-3 rounded-lg bg-white bg-opacity-20 border border-blue-300 border-opacity-30 focus:border-blue-400 focus:outline-none text-white placeholder-blue-200"
                  placeholder="••••••••"
                />
                <button
                  type="button"
                  onClick={() => setShowConfirmPassword(!showConfirmPassword)}
                  className="absolute right-3 top-1/2 transform -translate-y-1/2 text-blue-200 hover:text-white"
                >
                  {showConfirmPassword ? <EyeOff size={18} /> : <Eye size={18} />}
                </button>
              </div>
            </div>
            
            <div className="flex items-center">
              <input
                type="checkbox"
                id="accept-terms"
                checked={acceptTerms}
                onChange={(e) => setAcceptTerms(e.target.checked)}
                className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500"
              />
              <label htmlFor="accept-terms" className="ml-2 text-sm text-blue-200">
                I accept the <a href="#" className="text-blue-400 hover:text-blue-300">Terms of Service</a> and <a href="#" className="text-blue-400 hover:text-blue-300">Privacy Policy</a>
              </label>
            </div>
            
            <button
              type="submit"
              disabled={isLoading}
              className="w-full py-3 px-4 bg-gradient-to-r from-blue-500 to-indigo-600 text-white rounded-lg font-medium shadow-lg hover:from-blue-600 hover:to-indigo-700 focus:outline-none focus:ring-2 focus:ring-blue-400 focus:ring-opacity-50 transform transition hover:-translate-y-0.5"
            >
              {isLoading ? (
                <div className="flex items-center justify-center">
                  <div className="animate-spin rounded-full h-5 w-5 border-t-2 border-b-2 border-white mr-2"></div>
                  Creating account...
                </div>
              ) : (
                <div className="flex items-center justify-center">
                  <UserPlus size={18} className="mr-2" />
                  Sign Up
                </div>
              )}
            </button>
          </div>
        </form>
        
        <div className="mt-6 text-center">
          <p className="text-blue-200">
            Already have an account? <a href="/login" className="text-blue-400 hover:text-blue-300 font-medium">Sign in</a>
          </p>
        </div>
        
        {/* Animated pulsing circles in the background */}
        <div className="absolute top-1/4 left-1/4 w-32 h-32 bg-blue-500 rounded-full filter blur-3xl opacity-20 animate-pulse"></div>
        <div className="absolute bottom-1/4 right-1/3 w-40 h-40 bg-indigo-600 rounded-full filter blur-3xl opacity-20 animate-pulse" style={{ animationDelay: '1s' }}></div>
      </div>
    </div>
  );
};

export default SignUpForm;