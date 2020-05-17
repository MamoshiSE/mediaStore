import axios from 'axios';


const url = 'api/agents/';

class AgentService {
    // Get agents
 static getAgents() {
        return new Promise ((resolve,reject) => {
            axios.get(url).then((res) => {
                const data = res.data;
                resolve(
                    data.map(agent => ({
                        ...agent,
                        createdAt: new Date(agent.createdAt)
                    }))
                );
            })
            .catch((err)=> {
                reject(err);
            })
            
        });
    }

static getAgent(name) {
    return axios.get(`${url}${name}`)
}
    
}

export default AgentService;

