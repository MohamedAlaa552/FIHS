import axios from 'axios'
axios.defaults.withCredentials = true
const api = axios.create({
    baseURL: `http://farmerintelligenthelper.somee.com/api`,
    withCredentials: true
})
export default api

export const userApi = (token: string, rt?: string) => axios.create({
    baseURL: `http://farmerintelligenthelper.somee.com/api`,
    withCredentials: true,
    headers: {
        Authorization: `Bearer ${token}`,
        "Cookie": rt
    }
})

export const mlApi = axios.create({
    baseURL: `http://192.168.1.10:5000`,
    withCredentials: true
})
