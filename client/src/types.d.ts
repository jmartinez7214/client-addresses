export interface Client {
  id: number;
  firstName: string;
  lastName: string;
}

export interface Address {
  id: number;
  address: string;
  clientId: number;
}
