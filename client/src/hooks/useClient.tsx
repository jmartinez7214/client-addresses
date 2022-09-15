import { useEffect, useState } from "react";
import { Client } from "../types";
import { notification } from "antd";
import { getClient } from "../services/getClient";
import { useParams } from "react-router-dom";
import { parseParamToInt } from "../utils/parseParams";

const useClient = () => {
  const [client, setClient] = useState<Client>();
  const { id } = useParams();

  useEffect(() => {
    getClient(parseParamToInt(id))
      .then(setClient)
      .catch(() => {
        notification["error"]({
          message: "Server error, try later.",
        });
      });
  }, []);

  return {
    client,
  };
};

export default useClient;
