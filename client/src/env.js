export const dev = window.location.origin.includes('localhost')
export const baseURL = dev ? 'http://localhost:7045' : ''
export const useSockets = false
export const domain = 'https://zacapi.edu'
export const clientId = '65d629819541ddc914866b26'
export const audience = 'zacapi'
